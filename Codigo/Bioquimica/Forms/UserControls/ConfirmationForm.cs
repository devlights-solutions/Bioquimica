using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bioquimica.Forms.UserControls
{
    public partial class ConfirmationForm : Form
    {   
        public ConfirmationForm(string mensaje, string botonAceptarTexto, string botonCancelarTexto)
        {
            InitializeComponent();

            btnAceptar.Text = botonAceptarTexto;
            btnCancelar.Text = botonCancelarTexto;
            lblMensaje.Text = mensaje;

            var alturaBotones = 45 + lblMensaje.Size.Height;
            btnAceptar.Location = new Point(btnAceptar.Location.X, alturaBotones);
            btnCancelar.Location = new Point(btnCancelar.Location.X, alturaBotones);
            this.Height = alturaBotones + 92;
        }

    }
}
