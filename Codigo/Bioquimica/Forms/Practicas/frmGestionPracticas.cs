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
    public partial class frmGestionPracticas : Form
    {
        public frmGestionPracticas()
        {
            InitializeComponent();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Actualizar(null,null);
            }
        }

        private void Actualizar()
        {
            string descripcion = "";
            if (txtDescripcion.Valor != "")
                descripcion = txtDescripcion.Valor;
            var list = PracticasNegocio.Listado(descripcion);
            if (list!=null && list.Count > 0)
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

        private void frmGestionPracticas_Load(object sender, EventArgs e)
        {
            ucPaginador.PageSize = 50;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Actualizar(null,null);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar(null, null);
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                        Detalle();
                        break;
                }
            }
        }

        private void Detalle()
        {
            if (dgvListado.SelectedRows.Count>0)
            {
                frmDetallePractica frm =new frmDetallePractica(Convert.ToInt32(dgvListado.SelectedRows[0].Cells["practicaId"].Value));
                frm.ShowDialog();
            }
        }

        private void dgvListado_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                string icon = string.Empty;
                int paddingTop = 0;
                int paddingLeft = 0;
                switch (e.ColumnIndex)
                {
                    case 6:
                        icon = @"\Resources\details_icon.ico";
                        paddingLeft = 3;
                        paddingTop = 7;
                        break;
                }
                var ico = new Icon(appPath + icon);
                e.Graphics.DrawIcon(ico, e.CellBounds.Left + paddingLeft, e.CellBounds.Top + paddingTop);
                e.Handled = true;
            }
        }

        private void frmGestionPracticas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Actualizar(null, null);
            }
        }

        private void txtDescripcion_TeclaApretada(Keys tecla)
        {
            if (tecla == Keys.Enter)
            {
                Actualizar();
            }
        }

       
    }
}
