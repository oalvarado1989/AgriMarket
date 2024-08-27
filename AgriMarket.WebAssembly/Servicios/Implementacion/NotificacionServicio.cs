using AgriMarket.DTO;
using AgriMarket.WebAssembly.Servicios.Interfaz;
using Blazored.LocalStorage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgriMarket.WebAssembly.Servicios.Implementacion
{
    public class NotificacionServicio : INotificacionServicio
    {
        private readonly ILocalStorageService _localStorageService;

        public NotificacionServicio(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task GuardarNotificacion(NotificacionDTO notificacion)
        {
            var notificaciones = await _localStorageService.GetItemAsync<List<NotificacionDTO>>("notificaciones");
            if (notificaciones == null)
                notificaciones = new List<NotificacionDTO>();

            notificaciones.Add(notificacion);
            await _localStorageService.SetItemAsync("notificaciones", notificaciones);
        }

        public async Task<List<NotificacionDTO>> ObtenerNotificaciones()
        {
            var notificaciones = await _localStorageService.GetItemAsync<List<NotificacionDTO>>("notificaciones");
            return notificaciones ?? new List<NotificacionDTO>();
        }

        public async Task LimpiarNotificaciones()
        {
            await _localStorageService.RemoveItemAsync("notificaciones");
        }

        
    }
}