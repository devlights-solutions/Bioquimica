using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioquimica.Entidades;
using Bioquimica.Negocio;
namespace Bioquimica.Forms.Prepagas
{
    public partial class frmGestionPrepagas : Form
    {
        public frmGestionPrepagas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmABMPrepaga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Actualizar(null, null);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar(null, null);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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

        private void Actualizar()
        {
            string descripcion = "";
            if (txtDescripcion.Valor != "")
                descripcion = txtDescripcion.Valor;
            var list = PrepagasNegocio.Listado(descripcion);
            if (list != null &&  list.Count > 0)
            {
                ucPaginador.ActualizarBotones(list.Count);
                list = list.Skip(ucPaginador.PageSize * (ucPaginador.CurrentPage - 1)).Take(ucPaginador.PageSize).ToList();
                dgvListado.DataSource = list;
            }
            else
            {
                dgvListado.DataSource = null;
            }
        }

        private void Popup(string operacion)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                var frm = new frmABMPrepaga(Convert.ToInt32(dgvListado.SelectedRows[0].Cells["prepagaId"].Value), operacion);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Actualizar();
                }
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 7:
                        Popup("Detalle");
                        break;
                    case 8:
                        Popup("Editar");
                        break;
                    case 9:
                        Popup("Eliminar");
                        break;
                }
            }
        }

        private void dgvListado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
            {
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string icon = string.Empty;
                int paddingTop = 0;
                int paddingLeft = 0;
                switch (e.ColumnIndex)
                {
                    case 7:
                        icon = @"\Resources\details_icon.ico";
                        paddingLeft = 3;
                        paddingTop = 7;
                        break;
                    case 8:
                        icon = @"\Resources\ico_edit.ico";
                        paddingLeft = 3;
                        paddingTop = 7;
                        break;
                    case 9: 
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

        private void frmGestionPrepagas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
                Actualizar(null, null);
        }

        private void frmGestionPrepagas_Load(object sender, EventArgs e)
        {
            ucPaginador.PageSize = 30;
            ucPaginador.Next.Click += Siguiente;
            ucPaginador.Previous.Click += Anterior;
            ucPaginador.First.Click += Primero;
            ucPaginador.Last.Click += Ultimo;
            ucPaginador.PageSizeControl.TextChanged += Actualizar;
            Actualizar(null,null);
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Actualizar(null, null);
            }
        }

        private void txtDescripcion_TeclaApretada(Keys tecla)
        {
            if (tecla == Keys.Enter)
            {
                Actualizar(null, null);
            }
        }

        private void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != "NO" && e.Value != "SI")
            {
                e.Value = e.Value.ToString() == "True" ? "SI" : "NO";
            }
        }

        
        
    }
}
