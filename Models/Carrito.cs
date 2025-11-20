using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carrito_Compras_Zapatos.Models
{
    public class Carrito
    {
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public ICollection<CarritoDetalle>? Items { get; set; }
    }
}

//Proyecto : Carrito_Compras_Zapatos 2025