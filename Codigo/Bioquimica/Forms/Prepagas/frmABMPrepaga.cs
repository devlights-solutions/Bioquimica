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
using Bioquimica.Forms.UserControls;
using Bioquimica.Negocio;
using Util;
namespace Bioquimica.Forms.Prepagas
{
    public partial class frmABMPrepaga : Form
    {
        Prepaga _prepaga;
        private readonly int _prepagaId;
        private readonly string _operacion;
        public frmABMPrepaga(int prepagaId, string operacion)
        {
            InitializeComponent();
            _prepagaId = prepagaId;
            _operacion = operacion;
            this.Text = String.Format("{0} Prepaga", operacion);
        }

        public frmABMPrepaga()
        {
            InitializeComponent();
            _operacion = "Crear";
            this.Text = "Crear Prepaga";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_operacion == "Eliminar")
            {
                using (
                    var frm = new ConfirmationForm("Eliminando la prepaga se perderán todos sus órdenes asociadas " +
                                                   "y por lo tanto afectará a la facturación. " +
                                                   "Está seguro que desea eliminar la prepaga?", "Si", "No"))
                {
                    var result = frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        PrepagasNegocio.Eliminar(_prepagaId);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                    }
                }
            }
            else
            {
                errorProvider1.Dispose();
                txtPorcentajeIVA.EsObligatorio = chxDiscriminaIVA.Checked;
                var valido = Validacion.Validar(errorProvider1, new List<object>
                                                               {
                                                                   txtNombre,
                                                                   txtDomicilio,
                                                                   txtNBU,
                                                                   txtPorcentajeIVA
                                                               });
                if (valido)
                {
                    ArmarPrepaga();
                    if (PrepagasNegocio.Guardar(_prepaga))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void ArmarPrepaga()
        {
            if (_prepaga == null)
                _prepaga = new Prepaga();

            _prepaga.Nombre = txtNombre.Text;
            _prepaga.Domicilio = txtDomicilio.Text;
            _prepaga.NBU = txtNBU.Valor.GetValueOrDefault();
            _prepaga.DiscriminaIVA = chxDiscriminaIVA.Checked;
            _prepaga.PorcentajeIVA = txtPorcentajeIVA.Valor;
        }

        private void CargarControles()
        {
            _prepaga = PrepagasNegocio.Obtener(_prepagaId);
            txtNombre.Text = _prepaga.Nombre;
            txtDomicilio.Text = _prepaga.Domicilio;
            txtNBU.Valor= _prepaga.NBU;
            chxDiscriminaIVA.Checked = _prepaga.DiscriminaIVA;
            txtPorcentajeIVA.Valor = _prepaga.PorcentajeIVA;
        }

        private void frmABMPrepaga_Load(object sender, EventArgs e)
        {
            if (_prepagaId != 0)
            {
                CargarControles();
                if (_operacion == "Eliminar" || _operacion == "Detalle")
                {
                    txtNombre.Enabled = false;
                    txtNBU.Enabled = false;
                    txtDomicilio.Enabled = false;
                    txtPorcentajeIVA.Disabled = true;
                    chxDiscriminaIVA.Enabled = false;

                    if (_operacion == "Detalle")
                    {
                        btnAceptar.Visible = false;
                    }
                    
                }
            }
            else
                txtNombre.Select();
        }

        private void chxDiscriminaIVA_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (chxDiscriminaIVA.Checked)
            {
                txtPorcentajeIVA.Disabled = false;
            }
            else
            {
                txtPorcentajeIVA.Disabled = true;
                txtPorcentajeIVA.Valor = null;
            }
        }
    }
}
