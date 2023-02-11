using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data;

public class InventarioContext : DbContext
{
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Proveedor> Proveedor { get; set; }
    public DbSet<ProductoBase> ProductoBase { get; set; }
    public DbSet<ProductoContenido> ProductoContenido { get; set; }
    public DbSet<Producto> Producto { get; set; }

    public InventarioContext(DbContextOptions<InventarioContext> option) : base(option) {}

    protected override void OnConfiguring(DbContextOptionsBuilder option){
        if (!option.IsConfigured){
            
        }
    }
    protected override void OnModelCreating(ModelBuilder builder){

    }
}
