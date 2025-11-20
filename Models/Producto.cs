using System.ComponentModel.DataAnnotations;

namespace Carrito_Compras_Zapatos.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Nombre { get; set; } = default!;

        [MaxLength(50)]
        public string Categoria { get; set; } = default!;

        [MaxLength(10)]
        public string Talla { get; set; } = default!;

        [Required]
        public decimal Precio { get; set; }

        [MaxLength(255)]
        public string ImagenUrl { get; set; } = default!;

        public int Stock { get; set; }

        public ICollection<CarritoDetalle>? CarritoDetalles { get; set; }
        public ICollection<FacturaDetalle>? FacturaDetalles { get; set; }
    }
}
