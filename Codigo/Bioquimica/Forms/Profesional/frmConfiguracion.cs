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
using Util;
namespace Bioquimica.Forms.Profesional
{
    public partial class frmConfiguracion : Form
    {
        private Entidades.Profesional _Configuracion;
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            bool valido = Validacion.Validar(errorProvider1, new List<object>
                                                               {
                                                                   txtNombre,
                                                                   txtDNI,
                                                                   txtApellido,
                                                                   txtDNI,
                                                                   txtDomicilio,txtCUIT,txtTelefono,
                                                                   txtMP,txtProvincia
                                                               });

            if (valido)
            {
                if (_Configuracion == null)
                {
                    _Configuracion = new Entidades.Profesional();
                }
                _Configuracion.Apellido = txtApellido.Text;
                _Configuracion.Nombres = txtNombre.Text;
                _Configuracion.Domicilio = txtDomicilio.Text;
                _Configuracion.Telefono = txtTelefono.Text;
                _Configuracion.CUIT = txtCUIT.Text;
                _Configuracion.DNI = Convert.ToInt32(txtDNI.Valor);
                _Configuracion.MP = txtMP.Text;
                _Configuracion.MN = txtMN.Text;
                _Configuracion.Provincia = txtProvincia.Text;
                if (ProfesionalesNegocio.Guardar(_Configuracion))
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            _Configuracion = ProfesionalesNegocio.Obtener();
            if (_Configuracion != null)
            {
                this.Text = "Editar Configuración";
                txtApellido.Text = _Configuracion.Apellido;
                txtNombre.Text = _Configuracion.Nombres;
                txtDomicilio.Text = _Configuracion.Domicilio;
                txtTelefono.Text = _Configuracion.Telefono;
                txtCUIT.Text = _Configuracion.CUIT;
                txtDNI.Valor = _Configuracion.DNI.ToString();
                txtMP.Text = _Configuracion.MP;
                txtMN.Text = _Configuracion.MN;
                txtProvincia.Text = _Configuracion.Provincia;
            }
            else
            {
                this.Text = "Nueva Configuración";
            }
        }
    }
}
