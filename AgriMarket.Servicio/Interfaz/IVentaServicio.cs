using AgriMarket.DTO;

namespace AgriMarket.Servicio.Interfaz
{
    public interface IVentaServicio
    {
        Task<VentaDTO> Registar(VentaDTO modelo);
    }
}
