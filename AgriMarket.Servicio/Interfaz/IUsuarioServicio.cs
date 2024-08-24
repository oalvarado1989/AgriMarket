﻿using AgriMarket.DTO;

namespace AgriMarket.Servicio.Interfaz
{
    public interface IUsuarioServicio
    {
        Task<List<UsuarioDTO>> Lista(string rol, string buscar);
        Task<UsuarioDTO> Obtener(int id);
        Task<SesionDTO> Autorizacion(LoginDTO modelo);
        Task<UsuarioDTO> Crear(UsuarioDTO modelo);
        Task<bool> Editar(UsuarioDTO modelo);
        Task<bool> Eliminar(int id);
    }
}
