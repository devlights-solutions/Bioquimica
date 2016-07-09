using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioquimica.Forms.Facturaciones;
using Bioquimica.Forms.Ordenes;
using Bioquimica.Forms.Practicas;
using Bioquimica.Forms.Prepagas;
using Bioquimica.Forms.Profesional;

namespace Bioquimica.Forms.Principal
{
    public partial class mdiPrincipal : Form
    {
        public mdiPrincipal()
        {
            InitializeComponent();
        }


        private void AbrirTab(Form pantalla)
        {
            bool copia = false;
            foreach (var frm in this.MdiChildren)
            {
                if (pantalla.Name == frm.Name)
                {
                    copia = true;
                    frm.Focus();
                }
            }
            if (!copia)
            {
                pantalla.MdiParent = this;
                pantalla.Load += PantallaOnLoad;
                pantalla.Show();
            }
            else
            {
                pantalla.Dispose();
            }
        }

        private void PantallaOnLoad(object sender, EventArgs eventArgs)
        {
            ((Form)sender).WindowState = FormWindowState.Maximized;
        }

        private void tsbOrden_Click(object sender, EventArgs e)
        {
            AbrirTab(new frmGestionOrdenes());
        }

        private void tsbOrdenes_Click(object sender, EventArgs e)
        {
            AbrirTab(new frmGestionOrdenes());
        }

        private void tsbPrepagas_Click(object sender, EventArgs e)
        {
            AbrirTab(new frmGestionPrepagas());
        }

        private void tsbPracticas_Click(object sender, EventArgs e)
        {
            AbrirTab(new frmGestionPracticas());
        }

        private void tsbConfiguraciones_Click(object sender, EventArgs e)
        {
            var config = new frmConfiguracion();
            config.ShowDialog();
        }

        private void tsbAcercaDe_Click(object sender, EventArgs e)
        {
            var about = new AcercaDe.abxAcercaDe();
            about.Show();
        }

        private void tsbFacturación_Click(object sender, EventArgs e)
        {
            AbrirTab(new frmFacturacion());
        }
    }
}
