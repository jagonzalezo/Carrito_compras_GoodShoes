using Carrito_Compras_Zapatos.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Carrito_Compras_Zapatos.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; } = default!;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = default!;

        [Required, MaxLength(200)]
        public string Password { get; set; } = default!;

        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        public ICollection<CarritoController>? Carritos { get; set; }
        public ICollection<FacturaController>? Facturas { get; set; }
    }
}

//Proyecto : Carrito_Compras_Zapatos 2025