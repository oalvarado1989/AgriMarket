using AgriMarket.DTO;

namespace AgriMarket.WebAssembly.Servicios.Interfaz
{
    public interface IDashboardServicio
    {
        Task<ResponseDTO<DashboardDTO>> Resumen();
    }
}
