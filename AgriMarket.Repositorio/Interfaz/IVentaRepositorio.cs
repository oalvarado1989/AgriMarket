using AgriMarket.Modelo;

namespace AgriMarket.Repositorio.Interfaz
{
    public interface IVentaRepositorio : IGenericoRepositorio<Venta>
    {
        Task<Venta> Registrar(Venta modelo);
    }
}
