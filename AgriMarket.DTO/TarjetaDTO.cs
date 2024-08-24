using System.ComponentModel.DataAnnotations;

namespace AgriMarket.DTO
{
    public class TarjetaDTO
    {
        [Required(ErrorMessage = "Ingrese Titular")]
        public string? Titular { get; set; }

        [Required(ErrorMessage = "Ingrese Número de Tarjeta")]
        public string? Numero { get; set; }

        [Required(ErrorMessage = "Ingrese Vigencia")]
        public string? Vigencia { get; set; }

        [Required(ErrorMessage = "Ingrese CVV")]
        public string? CVV { get; set; }
    }
}
