namespace Carrito_Compras_Zapatos.Models
{
    public class FacturaDetalle
    {
        public int Id { get; set; }

        public int FacturaId { get; set; }
        public Factura? Factura { get; set; }

        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}

//Proyecto : Carrito_Compras_Zapatos 2025