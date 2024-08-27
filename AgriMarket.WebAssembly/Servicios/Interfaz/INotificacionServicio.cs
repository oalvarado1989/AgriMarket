using AgriMarket.DTO;

namespace AgriMarket.WebAssembly.Servicios.Interfaz
{
    public interface INotificacionServicio
    {
        Task GuardarNotificacion(NotificacionDTO notificacion);
        Task<List<NotificacionDTO>> ObtenerNotificaciones();
        Task LimpiarNotificaciones();
    }
}
