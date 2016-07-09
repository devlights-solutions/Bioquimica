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
namespace Bioquimica.Forms.Practicas
{
    public partial class frmDetallePractica : Form
    {
        private int _PracticaId=0;
        public frmDetallePractica()
        {
            InitializeComponent();
        }
        public frmDetallePractica(int practicaId)
        {
            InitializeComponent();
            _PracticaId = practicaId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetallePrepaga_Load(object sender, EventArgs e)
        {
            if (_PracticaId!=0)
            {
                CargarControles();
                pnlControles.Enabled = false;
            }
        }

        private void CargarControles()
        {
            var practica = PracticasNegocio.Obtener(_PracticaId);
            txtCodigo.Valor = practica.Codigo.ToString();
            txtDescripcion.Text = practica.Descripcion;
            txtNomenclador.Text = practica.Nomenclador;
            txtUB.Valor = practica.UB;
        }
    }
}
