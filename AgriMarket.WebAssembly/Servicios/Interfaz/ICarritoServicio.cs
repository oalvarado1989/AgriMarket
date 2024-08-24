using AgriMarket.DTO;

namespace AgriMarket.WebAssembly.Servicios.Interfaz
{
    public interface ICarritoServicio
    {
        event Action MostrarItems;

        int CantidadProductos();
        Task AgreagrCarrito(CarritoDTO modelo);
        Task EliminarCarrito(int idProducto);
        Task<List<CarritoDTO>> DevolverCarrito();
        Task LimpiarCarrito();
    }
}
