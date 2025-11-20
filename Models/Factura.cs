namespace Carrito_Compras_Zapatos.Models
{
    public class Factura
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public DateTime Fecha { get; set; } = DateTime.UtcNow;

        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }

        public ICollection<FacturaDetalle>? Detalles { get; set; }
    }
}

//Proyecto : Carrito_Compras_Zapatos 2025