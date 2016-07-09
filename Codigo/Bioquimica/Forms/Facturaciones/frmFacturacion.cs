using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bioquimica.Negocio;
using Bioquimica.Entidades;
using Microsoft.Reporting.WinForms;

namespace Bioquimica.Forms.Facturaciones
{
    public partial class frmFacturacion : Form
    {
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = new DateTime(dtpFechaDesde.Value.Year, dtpFechaDesde.Value.Month,1);
            CargarComboPrepaga();
        }

        private void rptFacturacion_ReportRefresh(object sender, CancelEventArgs e)
        {
            Actualizar();
        }

        private void CargarComboPrepaga()
        {
            var _Prepagas = PrepagasNegocio.ListadoParaCombo();
            _Prepagas.Insert(0, new Prepaga() { PrepagaId = 0, Nombre = "Seleccionar..", Domicilio = "", NBU = 0, });
            cboPrepagas.DisplayMember = "Nombre";
            cboPrepagas.ValueMember = "PrepagaId";
            cboPrepagas.DataSource = _Prepagas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Actualizar();
        }

        private void Actualizar()
        {
            if (Validacion())
            {
                var prepagaId = Convert.ToInt32(cboPrepagas.SelectedValue);
                var prepaga = PrepagasNegocio.Obtener(prepagaId);

                this.Cursor = Cursors.WaitCursor;
                rptFacturacion.LocalReport.DataSources.Clear();
                rptFacturacion.ProcessingMode = ProcessingMode.Local;
                ReporteLoadReportDefinition(rptFacturacion.LocalReport, prepaga.DiscriminaIVA);
                var fechaDesde = dtpFechaDesde.Value.AddDays(-1);
                var fechaHasta = dtpFechaHasta.Value.AddDays(1);
                
                

                var facturacion = FacturacionNegocio.Detalle(fechaDesde, fechaHasta, prepagaId);
                var facturacionConIva = FacturacionNegocio.FacturacionConIVA(fechaDesde, fechaHasta, prepagaId);
                var encabezado = FacturacionNegocio.Encabezado();
                var pie = FacturacionNegocio.Pie(fechaDesde, fechaHasta, prepagaId);
                rptFacturacion.LocalReport.DataSources.Add(new ReportDataSource("dsEncabezado", encabezado));
                rptFacturacion.LocalReport.DataSources.Add(new ReportDataSource("dsDetalle", facturacion));
                rptFacturacion.LocalReport.DataSources.Add(new ReportDataSource("dsPie", pie));

                var parametros = new List<ReportParameter>
                                     {
                                         new ReportParameter("FechaDesde", fechaDesde.ToShortDateString()),
                                         new ReportParameter("FechaHasta", fechaHasta.ToShortDateString()),
                                         new ReportParameter("Prepaga", prepaga.Nombre)
                                     };

                if (prepaga.DiscriminaIVA)
                {
                    rptFacturacion.LocalReport.DataSources.Add(new ReportDataSource("dsIVA", facturacionConIva));
                }

                
                rptFacturacion.LocalReport.SetParameters(parametros);
                this.rptFacturacion.RefreshReport();
                this.Cursor = Cursors.Default;
            }
        }

        private bool Validacion()
        {
            if (dtpFechaDesde.Value>dtpFechaHasta.Value)
            {
                btnBuscar.Enabled = false;
                return false;
            }
            if (Convert.ToInt32(cboPrepagas.SelectedValue)==0)
            {
                btnBuscar.Enabled = false;
                return false;
            }
            btnBuscar.Enabled = true;
            return true;
        }

        private void ReporteLoadReportDefinition(LocalReport localReport, bool discriminaIVA)
        {
            localReport.LoadReportDefinition(discriminaIVA
                ? new MemoryStream(Bioquimica.Properties.Resources.rptFacturacionConIVA)
                : new MemoryStream(Bioquimica.Properties.Resources.rptFacturacion));
        }

        private void frmFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Actualizar();
        }

        private void cboPrepagas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Validacion();
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            Validacion();
        }

    }
}
