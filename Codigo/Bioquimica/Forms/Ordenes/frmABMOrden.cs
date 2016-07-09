using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bioquimica.Entidades;
using Bioquimica.Negocio;
using System.Drawing;
using Bioquimica.Forms.UserControls;
using Telerik.WinControls;
using Util;
namespace Bioquimica.Forms.Ordenes
{
    public partial class frmABMOrden : Form
    {
        private Orden _orden;
        private readonly int _ordenId = 0;
        private readonly bool _detalle;
        private List<Practica> _practicasPorOrden;
        private List<Prepaga> _prepagas;
        private decimal _nbu;
        private readonly int _prepagaId;
        private bool _discriminaIvaOriginal = false;
        private string _operacion;

        public List<Practica> Practicas { get; set; }

        public frmABMOrden(int prepagaId)
        {
            InitializeComponent();
            this.Text = "Crear Orden";
            _prepagaId = prepagaId;
            _operacion = "CREAR";
        }

        public frmABMOrden(int ordenId, bool detalle)
        {
            InitializeComponent();
            _ordenId = ordenId;
            _detalle = detalle;
            this.Text = detalle ? "Detalle de Orden" : "Editar Orden";
            _operacion = detalle ? "DETALLE" : "EDITAR";
        }

        private void frmABMOrden_Load(object sender, EventArgs e)
        {
            _prepagas = PrepagasNegocio.ListadoParaCombo();
            CargarComboPrepaga();
            CargarComboPractica();
            if (_ordenId != 0)
            {
                CargarControles();
                _discriminaIvaOriginal = _orden.DiscriminaIVA;
                if (_detalle)
                {
                    pnlControles.Enabled = false;
                    btnAceptar.Visible = false;
                    dgvListado.Columns["ExcEliminar"].Visible = false;
                    gbxPracticas.Enabled = true;
                    cboPrepaga.Enabled = false;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    gbxPracticas.Enabled = true;
                }
            }
            if (this.Text == "Crear Orden" && _prepagaId != 0)
            {
                cboPrepaga.Valor = _prepagaId;
            }

            txtNroOrden.Select();
        }

        private void CargarControles()
        {
            _orden = OrdenesNegocio.Obtener(_ordenId);
            txtNombre.Text = _orden.PacienteNombre;
            txtNroOrden.Valor = _orden.NroOrden.ToString();
            dtpFechaAtencion.Fecha = _orden.FechaAtencion;
            dtpFechaNacimiento.Fecha = _orden.PacienteFechaNacimiento.Value;
            txtDNI.Valor = _orden.PacienteDNI.ToString();
            cboPrepaga.Valor = _orden.PrepagaId;
            chxDiscriminaIVA.Checked = _orden.DiscriminaIVA;
            _practicasPorOrden = _orden.PracticasOrdenes.Select(p => p.Practica).ToList();
            _nbu = _prepagas.First(p => p.PrepagaId == _orden.PrepagaId).NBU;

            foreach (Practica practica in _practicasPorOrden)
            {
                dgvListado.Rows.Add();
                dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["PracticaId"].Value = practica.PracticaId;
                dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["Codigo"].Value = practica.Codigo;
                dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["Practica"].Value = practica.Descripcion;
                dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["UB"].Value = practica.UB;
            }

            if (_orden.Prepagas.DiscriminaIVA)
            {
                chxDiscriminaIVA.Visible = true;
            }
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (dgvListado.Rows.Count > 0)
            {
                decimal total = 0;
                for (int i = 0; i <= dgvListado.Rows.Count - 1; i++)
                {
                    dgvListado.Rows[i].Cells["SubTotal"].Value = Convert.ToDecimal(dgvListado.Rows[i].Cells["UB"].Value)*_nbu;
                    total += Convert.ToDecimal(dgvListado.Rows[i].Cells["SubTotal"].Value.ToString().Replace("$", ""));
                }
                lblTotal.Text = String.Format("${0}", total.ToString("N2"));
            }
            else
            {
                lblTotal.Text = "$0";
            }
        }

        private void dgvListado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var icon = @"\Resources\delete_icon.ico";
                Icon ico = new Icon(appPath + icon);
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + 5, e.CellBounds.Top + 8);
                e.Handled = true;
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        SuprimirFila();
                        break;
                }
            }
        }

        private void CargarComboPrepaga()
        {
            _prepagas.Insert(0,new Prepaga(){PrepagaId = 0,Nombre = "",Domicilio = "",NBU = 0,});
            cboPrepaga.DataSource = _prepagas;
        }

        private void CargarComboPractica()
        {
            Practicas = PracticasNegocio.Listado();
            Practicas.Insert(0, new Practica());
            
            cboPracticas.DisplayMember = "Descripcion";
            cboPracticas.ValueMember = "PracticaId";
            cboPracticas.DataSource = Practicas.ToList();

            cboCodigos.DisplayMember = "CodigoParaDropdown";
            cboCodigos.ValueMember = "PracticaId";
            cboCodigos.DataSource = Practicas.ToList();
        }

        private void SuprimirFila()
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                dgvListado.Rows.RemoveAt(dgvListado.SelectedRows[0].Index);
                CalcularTotal();
            }
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (chxDiscriminaIVA.Checked && !string.IsNullOrEmpty(txtDNI.Valor) && (_operacion == "CREAR" || (_operacion == "EDITAR" && !_discriminaIvaOriginal)))
                {
                    var prepaga = _prepagas.FirstOrDefault(x => x.PrepagaId == cboPrepaga.Valor);
                    var existentesSinDiscriminar = OrdenesNegocio.ExisteSinDiscriminarIVA(Convert.ToInt32(txtDNI.Valor), prepaga.PrepagaId);

                    if (existentesSinDiscriminar)
                    {
                        var mensaje =
                        String.Format(
                            "Existen órdenes para el paciente con dni: {0} y obra social: \"{1}\" que no discriminan IVA. Desea que estas órdenes también discriminen IVA?",
                            txtDNI.Valor, prepaga.Nombre);
                        using (var frm = new ConfirmationForm(mensaje, "Si", "No"))
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                OrdenesNegocio.DiscriminarIVA(Convert.ToInt32(txtDNI.Valor), prepaga.PrepagaId);
                            }
                        }
                    }
                    
                    Guardar();
                }
                else
                {
                    Guardar();
                }
            }
            else
            {
                this.DialogResult=DialogResult.None;
            }
        }

        private void Guardar()
        {
            if (_orden == null)
            {
                _orden = new Orden();
            }
            ArmarOrden();

            if (OrdenesNegocio.Guardar(_orden))
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void ArmarOrden()
        {
            _orden.FechaAtencion = dtpFechaAtencion.Fecha;
            _orden.PacienteFechaNacimiento = dtpFechaNacimiento.Fecha;
            if (!string.IsNullOrEmpty(txtDNI.Valor))
                _orden.PacienteDNI = Convert.ToInt32(txtDNI.Valor);
            
            
            _orden.PacienteNombre = txtNombre.Text;
            _orden.NroOrden = Convert.ToInt32(txtNroOrden.Valor);
            _orden.PrepagaId = cboPrepaga.Valor;
            _orden.DiscriminaIVA = chxDiscriminaIVA.Checked;
            _orden.PracticasOrdenes.Clear();
            for (int i = 0; i <= dgvListado.Rows.Count - 1; i++)
            {
                _orden.PracticasOrdenes.Add(new PracticasOrdenes() { PracticaId = Convert.ToInt32(dgvListado.Rows[i].Cells["PracticaId"].Value), OrdenId = _orden.OrdenId });   
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private bool Validar()
        {
            errorProvider1.Dispose();
            bool valido = Validacion.Validar(errorProvider1, new List<object>
                                                               {
                                                                   txtNombre,
                                                                   txtNroOrden,
                                                                   cboPrepaga
                                                               });
            if (dgvListado.Rows.Count == 0)
            {
                errorProvider1.SetError(cboPracticas, "Debe agregar al menos una práctica.");
                errorProvider1.SetIconPadding(cboPracticas, 2);
                valido = false;
            }
            return valido;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboPracticas.SelectedValue) != 0)
            {
                bool existe = false;
                for (int i = 0; i < dgvListado.Rows.Count - 1; i++)
                {
                    if (Convert.ToInt32(dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["PracticaId"].Value) == Convert.ToInt32(cboPracticas.SelectedValue))
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    var practica = PracticasNegocio.Obtener(Convert.ToInt32(cboPracticas.SelectedValue));
                    dgvListado.Rows.Add();
                    dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["PracticaId"].Value = practica.PracticaId;
                    dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["Codigo"].Value = practica.Codigo;
                    dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["Practica"].Value = practica.Descripcion;
                    dgvListado.Rows[dgvListado.Rows.Count - 1].Cells["UB"].Value = practica.UB;
                    CalcularTotal();
                    cboPracticas.SelectedValue = 0;
                }
                cboCodigos.Focus();
            }
        }
        
        private void cboPrepaga_ComboSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboPrepaga.Valor) != 0)
            {
                var prepaga = _prepagas.First(p => p.PrepagaId == Convert.ToInt32(cboPrepaga.Valor));
                _nbu = prepaga.NBU;
                CalcularTotal();
                gbxPracticas.Enabled = true;
                
                if (prepaga.DiscriminaIVA)
                {
                    chxDiscriminaIVA.Visible = true;
                }
                else
                {
                    chxDiscriminaIVA.Visible = false;
                    chxDiscriminaIVA.Checked = false;
                }
            }
            else
            {
                chxDiscriminaIVA.Visible = false;
                chxDiscriminaIVA.Checked = false;
            }
        }

        private void cboCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCodigos.SelectedValue.ToString()))
            {
                cboPracticas.SelectedIndex = 0;
            }
            else
            {
                cboPracticas.SelectedValue = cboCodigos.SelectedValue;
            }

        }

        private void cboPracticas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboPracticas.SelectedValue.ToString()))
            {
                cboCodigos.SelectedIndex = 0;
            }
            else
            {
                cboCodigos.SelectedValue = cboPracticas.SelectedValue;
            }
        }

        private void cboCodigos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar_Click(null, null);
            }
        }

        private void cboPracticas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar_Click(null, null);
            }
        }

        private void txtDNI_Cambio()
        {
            if (!string.IsNullOrEmpty(txtDNI.Valor) && string.IsNullOrEmpty(txtNombre.Text))
            {
                int val;
                if (int.TryParse(txtDNI.Valor, out val))
                {
                    var orden = OrdenesNegocio.ObtenerPorDni(val);
                    if (orden != null)
                    {
                        txtNombre.Text = orden.PacienteNombre;
                    }
                }
            }
            
        }

    }
}
