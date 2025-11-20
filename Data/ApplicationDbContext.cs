using Carrito_Compras_Zapatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Carrito_Compras_Zapatos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } = default!;
        public DbSet<Producto> Productos { get; set; } = default!;
        public DbSet<Carrito> Carritos { get; set; } = default!;
        public DbSet<CarritoDetalle> CarritoDetalles { get; set; } = default!;
        public DbSet<Factura> Facturas { get; set; } = default!;
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // precisión de decimal para precios
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FacturaDetalle>()
                .Property(d => d.PrecioUnitario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FacturaDetalle>()
                .Property(d => d.PrecioTotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Factura>()
                .Property(f => f.Subtotal)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Factura>()
                .Property(f => f.IVA)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Factura>()
                .Property(f => f.Total)
                .HasPrecision(10, 2);
        }
    }
}

//Proyecto : Carrito_Compras_Zapatos 2025