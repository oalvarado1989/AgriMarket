﻿namespace AgriMarket.DTO
{
    public class DetalleVentaDTO
    {
        public int IdDetalleVenta { get; set; }

        public int? IdProducto { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Total { get; set; }

    }
}
