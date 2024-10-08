﻿namespace AgriMarket.DTO
{
    public class VentaDTO
    {
        public int IdVenta { get; set; }

        public int? IdUsuario { get; set; }

        public decimal? Total { get; set; }

        public virtual ICollection<DetalleVentaDTO> DetalleVenta { get; set; } = new List<DetalleVentaDTO>();

    }
}
