using AgriMarket.DTO;
using AgriMarket.Modelo;
using AgriMarket.Repositorio.Interfaz;
using AgriMarket.Servicio.Interfaz;

namespace AgriMarket.Servicio.Implementacion
{
    public class DashboardServicio : IDashboardServicio
    {
        private readonly IVentaRepositorio _ventaRepositorio;
        private readonly IGenericoRepositorio<Usuario> _usuarioRepositorio;
        private readonly IGenericoRepositorio<Producto> _productoRepositorio;
        public DashboardServicio(
            IVentaRepositorio ventaRepositorio,
            IGenericoRepositorio<Usuario> usuarioRepositorio,
            IGenericoRepositorio<Producto> productoRepositorio)
        {
            _ventaRepositorio = ventaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
            _productoRepositorio = productoRepositorio;
        }

        private string Ingresos()
        {
            var consulta = _ventaRepositorio.Consultar();
            decimal? ingresos = consulta.Sum(x => x.Total);
            return Convert.ToString(ingresos);
        }

        private int Ventas()
        {
            var consulta = _ventaRepositorio.Consultar();
            int total = consulta.Count();
            return total;
        }

        private int Consumidores()
        {
            var consulta = _usuarioRepositorio.Consultar(u => u.Rol.ToLower() == "consumidor");
            int total = consulta.Count();
            return total;
        }

        private int Productos()
        {
            var consulta = _productoRepositorio.Consultar();
            int total = consulta.Count();
            return total;
        }

        public DashboardDTO Resumen()
        {
            try
            {
                DashboardDTO dto = new DashboardDTO()
                {
                    TotalIngresos = Ingresos(),
                    TotalVentas = Ventas(),
                    TotalConsumidores = Consumidores(),
                    TotalProductos = Productos(),
                };
                return dto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
