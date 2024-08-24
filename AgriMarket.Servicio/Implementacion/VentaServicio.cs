using AgriMarket.DTO;
using AgriMarket.Modelo;
using AgriMarket.Repositorio.Interfaz;
using AgriMarket.Servicio.Interfaz;
using AutoMapper;

namespace AgriMarket.Servicio.Implementacion
{
    public class VentaServicio : IVentaServicio
    {
        private readonly IVentaRepositorio _modeloRepositorio;
        private readonly IMapper _mapper;
        public VentaServicio(IVentaRepositorio modeloRepositorio, IMapper mapper)
        {
            _modeloRepositorio = modeloRepositorio;
            _mapper = mapper;
        }

        public async Task<VentaDTO> Registar(VentaDTO modelo)
        {
            try
            {
                var dbModelo = _mapper.Map<Venta>(modelo);
                var ventaGenerada = await _modeloRepositorio.Registrar(dbModelo);

                if (ventaGenerada.IdVenta == 0)
                    throw new TaskCanceledException("No se puede registrar");
                return _mapper.Map<VentaDTO>(ventaGenerada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
