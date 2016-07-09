using System;
using System.Collections.Generic;
using System.Linq;
using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class FacturacionRepository:RepositoryBase
    {
        public List<Facturacion> Detalle(DateTime fechaDesde,DateTime fechaHasta, int prepagaId)
        {
            try
            {
                return Contexto.Detalle(fechaDesde,fechaHasta,prepagaId).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Configuracion> Encabezado()
        {
            try
            {
                return Contexto.Encabezado().ToList();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Pie> Pie(DateTime fechaDesde, DateTime fechaHasta, int prepagaId)
        {
            try
            {
                return Contexto.Pie(fechaDesde, fechaHasta, prepagaId).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<FacturacionConIVARow> FacturacionConIVA(DateTime fechaDesde, DateTime fechaHasta, int prepagaId)
        {
            return Contexto.FacturacionConIVA(fechaDesde, fechaHasta, prepagaId).ToList();
        }
    }
}
