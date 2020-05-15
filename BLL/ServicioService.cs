using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ServicioService
    {
        List<Servicios> servicios = new List<Servicios>();

        ServiciosRepository servicioRepositorio = new ServiciosRepository();

        public string Guardar(Servicios servicios)
        {
             servicioRepositorio.guardar(servicios);
             return $"Se registro el pago de la entidad {servicios.Nombre} Satisfactoriamente";

        }

        public List<Servicios> Consultar()
        {
            return servicioRepositorio.Consultar();
        }

        public List<Servicios> FiltroTipoServicioPublico()
        {
            servicios.Clear();
            servicios = Consultar();

            return servicios.Where(p => p.TipoServicio.Contains("Servicios Publicos")).ToList();
        }

        public List<Servicios> FiltroTipoComprasProvedores()
        {
            servicios.Clear();
            servicios = Consultar();

            return servicios.Where(p => p.TipoServicio.Contains("Compras a Provedores")).ToList();
        }
        public List<Servicios> FiltroTipoPagosContratistas()
        {
            servicios.Clear();
            servicios = Consultar();

            return servicios.Where(p => p.TipoServicio.Contains("Pagos a Contratistas")).ToList();
        }


        public double CalcularTotal()
        {
            double total = 0;
            servicios.Clear();
            servicios = Consultar();
            total = servicios.Sum(p => p.Valor);
            return total;
        }

        public double CalcularTotalServicioPublico()
        {
            servicios.Clear();
            servicios = Consultar();
            double totalservicio = servicios.Where(p => p.TipoServicio.Equals("Servicios Publicos")).Sum(p => p.Valor);
            return totalservicio;
        }
        public double CalcularTotalComprasProvedores()
        {
            servicios.Clear();
            servicios = Consultar();
            double totalprovedores = servicios.Where(p => p.TipoServicio.Equals("Compras a Provedores")).Sum(p => p.Valor);
            return totalprovedores;
        }
        public double CalcularTotalPagosContratistas()
        {
            servicios.Clear();
            servicios = Consultar();
            double totalPagos = servicios.Where(p => p.TipoServicio.Equals("Pagos a Contratistas")).Sum(p => p.Valor);
            return totalPagos;
        }

        public double NumeroPagos()
        {
            servicios.Clear();
            servicios = Consultar();
            double pagos = servicios.Count();
            return pagos;
        }

        public double NumeroPagosServicios()
        {
            servicios.Clear();
            servicios = Consultar();
            double pagosServicios = servicios.Where(p => p.TipoServicio.Equals("Servicios Publicos")).Count();
            return pagosServicios;
        }

        public double NumeroPagosCompras()
        {
            servicios.Clear();
            servicios = Consultar();
            double pagosCompras = servicios.Where(p => p.TipoServicio.Equals("Compras a Provedores")).Count();
            return pagosCompras;
        }

        public double NumeroPagosContratistas()
        {
            servicios.Clear();
            servicios = Consultar();
            double pagosContratistas = servicios.Where(p => p.TipoServicio.Equals("Pagos a Contratistas")).Count();
            return pagosContratistas;
        }

        public List<Servicios> FiltroFecha(int mes, int año, string tipoServicio)
        {
            Consultar();
            return servicios .Where(p => p.Fecha.Equals(mes) && p.Fecha.Equals(año)).ToList();

        }
    }
}
