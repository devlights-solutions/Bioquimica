using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioquimica.Forms.UserControls;
using Bioquimica.Negocio;
using Bioquimica.Entidades;

namespace Bioquimica.Forms.Ordenes
{
    public partial class frmGestionOrdenes : Form
    {
        public frmGestionOrdenes()
        {
            InitializeComponent();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 12 || e.ColumnIndex == 13 || e.ColumnIndex == 14) && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 12:
                        Modificar(true);
                        break;
                    case 13:
                        Modificar(false);
                        break;
                    case 14:
                        Eliminar();
                        break;
                }
            }
        }

        private void dgvListado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == 12 || e.ColumnIndex == 13 || e.ColumnIndex == 14) && e.RowIndex >= 0)
            {
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string icon = string.Empty;
                int paddingTop = 0;
                int paddingLeft = 0;
                switch (e.ColumnIndex)
                {
                    case 12:
                        icon = @"\Resources\details_icon.ico";
                        paddingLeft = 3;
                        paddingTop = 7;
                        break;
                    case 13:
                        icon = @"\Resources\ico_edit.ico";
                        paddingLeft = 3;
                        paddingTop = 7;
                        break;
                    case 14:
                        icon = @"\Resources\delete_icon.ico";
                        paddingLeft = 5;
                        paddingTop = 7;
                        break;
                }
                var ico = new Icon(appPath + icon);
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + paddingLeft, e.CellBounds.Top + paddingTop);
                e.Handled = true;
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var prepagaId = (cboPrepagas.SelectedValue == null) ? 0 : Convert.ToInt32(cboPrepagas.SelectedValue);
            var frm = new frmABMOrden(prepagaId);
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Actualizar(null, null);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar(null, null);
        }

        private void Modificar(bool detalle)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                var frm = new frmABMOrden(Convert.ToInt32(dgvListado.SelectedRows[0].Cells[0].Value), detalle);
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    Actualizar(null, null);
                }
            }
        }

        private void Eliminar()
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                using (
                    var frm = new ConfirmationForm("Está seguro que desea eliminar la orden?", "Si", "No"))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        if (OrdenesNegocio.Eliminar(Convert.ToInt32(dgvListado.SelectedRows[0].Cells[0].Value)))
                        {
                            Actualizar(null, null);
                        }
                    }
                }
            }
        }

        private void Actualizar()
        {
            int nroOrden = 0;
            int prepaga = 0;
            string paciente = "";
            DateTime fecha=DateTime.MaxValue;
            List<Orden> list;
            if (ckbFecha.Checked)
            {
                fecha = dtpFechaAtencion.Fecha;
            }
            if (txtPaciente.Valor != "")
            {
                paciente= txtPaciente.Valor;
            }
            if (txtNroOrden.Valor != "")
            {
                nroOrden= Convert.ToInt32(txtNroOrden.Valor);
            }
            if (Convert.ToInt32(cboPrepagas.SelectedValue)!=0)
            {
                prepaga = Convert.ToInt32(cboPrepagas.SelectedValue);
            }
            bool? discrimina = null;
            if (cboDiscriminaIVA.SelectedValue.ToString() == "1")
            {
                discrimina = true;
            }
            else if (cboDiscriminaIVA.SelectedValue.ToString() == "2")
            {
                discrimina = false;
            }
            list = OrdenesNegocio.Listado(nroOrden, prepaga, paciente, fecha, discrimina);
            if (list != null && list.Count > 0)
            {
                ucPaginador.ActualizarBotones(list.Count);
                list= list.Skip(ucPaginador.PageSize * (ucPaginador.CurrentPage - 1)).Take(ucPaginador.PageSize).ToList();
                dgvListado.DataSource = list;
            }
            else
            {
                dgvListado.DataSource = null;
            }

        }
        
        private void ckbFecha_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void frmGestionOrdenes_Load(object sender, EventArgs e)
        {
            CargarComboPrepaga();
            CargarComboIVA();
            ucPaginador.PageSize = 30;
            ucPaginador.Next.Click += Siguiente;
            ucPaginador.Previous.Click += Anterior;
            ucPaginador.First.Click += Primero;
            ucPaginador.Last.Click += Ultimo;
            ucPaginador.PageSizeControl.TextChanged += Actualizar;
            Actualizar(null, null);
        }

        #region Handlers

        private void Actualizar(object sender, EventArgs e)
        {
            ucPaginador.CurrentPage = 1;
            Actualizar();
        }
       
        private void Siguiente(object sender, EventArgs e)
        {
            if (ucPaginador.PuedeAvanzar)
            {
                ucPaginador.CurrentPage = ucPaginador.CurrentPage + 1;
                Actualizar();
            }
        }

        private void Anterior(object sender, EventArgs e)
        {
            if (ucPaginador.PuedeRetroceder)
            {
                ucPaginador.CurrentPage = ucPaginador.CurrentPage - 1;
                Actualizar();
            }
        }

        private void Primero(object sender, EventArgs e)
        {
            if (ucPaginador.PuedeRetroceder)
            {
                ucPaginador.CurrentPage = 1;
                Actualizar();
            }
        }

        private void Ultimo(object sender, EventArgs e)
        {
            if (ucPaginador.PuedeAvanzar)
            {
                ucPaginador.CurrentPage = ucPaginador.PageTotal.GetValueOrDefault();
                Actualizar();
            }
        }

        #endregion

        private void CargarComboPrepaga()
        {
            var _Prepagas = PrepagasNegocio.ListadoParaCombo();
            _Prepagas.Insert(0, new Prepaga() { PrepagaId = 0, Nombre = "Seleccionar..", Domicilio = "", NBU = 0, });
            cboPrepagas.DisplayMember = "Nombre";
            cboPrepagas.ValueMember = "PrepagaId";
            cboPrepagas.DataSource = _Prepagas;
        }

        private void CargarComboIVA()
        {
            var iva = new List<KeyValuePair<int, string>>();
            iva.Add(new KeyValuePair<int, string>(0, "(TODOS)"));
            iva.Add(new KeyValuePair<int, string>(1, "SI"));
            iva.Add(new KeyValuePair<int, string>(2, "NO"));
            cboDiscriminaIVA.DisplayMember = "Value";
            cboDiscriminaIVA.ValueMember = "Key";
            cboDiscriminaIVA.DataSource = iva;
        }

        private void frmGestionOrdenes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Actualizar(null, null);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Actualizar(null,null);
        }

        private void ckbFecha_CheckedChanged_1(object sender, EventArgs e)
        {
            //dtpFechaAtencion.Enabled = !dtpFechaAtencion.Enabled;
        }

        private void txtNroOrden_TeclaApretada(Keys tecla)
        {
            if (tecla == Keys.Enter)
            {
                Actualizar(null, null);
            }
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.Value != "NO" && e.Value != "SI")
            {
                e.Value = e.Value.ToString() == "True" ? "SI" : "NO";
            }
        }

    }
}
