using System;
using System.Collections.Generic;
using Bioquimica.Entidades;
using Bioquimica.Datos.Repositorio;

namespace Bioquimica.Negocio
{
    public class FacturacionNegocio : NegocioBase<FacturacionRepository>
    {
        public static List<Facturacion> Detalle(DateTime fechaDesde, DateTime fechaHasta, int prepagaId)
        {
            return RepositoryInstancia.Detalle(fechaDesde,fechaHasta,prepagaId);
        }



        public static List<FacturacionConIVARow> FacturacionConIVA(DateTime fechaDesde, DateTime fechaHasta, int prepagaId)
        {
            return RepositoryInstancia.FacturacionConIVA(fechaDesde, fechaHasta, prepagaId);
        }

        public static List<Configuracion> Encabezado()
        {
            return RepositoryInstancia.Encabezado();
        }

        public static List<Pie> Pie(DateTime fechaDesde, DateTime fechaHasta, int prepagaId)
        {
            return RepositoryInstancia.Pie(fechaDesde, fechaHasta, prepagaId);
        }

    }
}
