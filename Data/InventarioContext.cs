using InventarioBlazor.Models;
using InventarioBlazor.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data;

public class InventarioContext : DbContext
{
    public DbSet<Categoria> TbCategoria { get; set; }
    public DbSet<Proveedor> TbProveedor { get; set; }
    public DbSet<ProductoBase> TbProductoBase { get; set; }
    public DbSet<ProductoContenido> TbProductoContenido { get; set; }
    public DbSet<Producto> TbProducto { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<ClienteJuridico> ClienteJuridico { get; set; }
    public DbSet<ClienteNatural> ClienteNatural { get; set; }

    public InventarioContext(DbContextOptions<InventarioContext> option) : base(option) {}

    protected override void OnConfiguring(DbContextOptionsBuilder option){
        if (!option.IsConfigured){
            option.UseSqlServer("Server=(local); Database=Inventario;Integrated Security = true");
        }
    }
    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Categoria>().HasData(InitCategoria());
        builder.Entity<Proveedor>().HasData(InitProveedor());
        builder.Entity<ProductoBase>().HasData(InitProductoBase());
        builder.Entity<ProductoContenido>().HasData(InitProductContent());
        builder.Entity<Producto>().HasData(InitProducts());

    }

    private IEnumerable<Categoria> InitCategoria(){
        List<Categoria> categories = new List<Categoria>(){
            new (){IdCategoria=1,Nombre="Lacteos",Descripcion="Lorem ipsum"},
            new (){IdCategoria=2, Nombre = "Bebidas carbonatadas",Descripcion="Lorem ipsum"},
            new (){IdCategoria=3, Nombre="Aseo personal", Descripcion="Lorem ipsum"},
            new (){IdCategoria=4, Nombre="Aseo del hogar",Descripcion="Lorem ipsum"},
            new (){IdCategoria=5, Nombre="Snacks", Descripcion="Lorem ipsum"},
            new (){IdCategoria=6, Nombre="Proteinas", Descripcion="Lorem ipsum"}
        };

        return categories;
    }

    private IEnumerable<Proveedor> InitProveedor(){
        List<Proveedor> providers = new List<Proveedor>(){
            new(){IdProveedor=1, Nombre="Coca Cola Company",Telefono="22113355"},
            new(){IdProveedor=2, Nombre="Pepsi",Telefono="88990123"},
            new(){IdProveedor=3, Nombre="Dell",Telefono="78901010"}
        };

        return providers;
    }

    private IEnumerable<ProductoBase> InitProductoBase(){
        List<ProductoBase> productsBase = new List<ProductoBase>(){
            new(){IdBase = 1,IdCategoria=2,IdProveedor=1,Nombre="Coca cola"},
            new(){IdBase=2,IdCategoria=2, IdProveedor=1,Nombre="Fanta roja"},
            new(){IdBase=3,IdCategoria=2, IdProveedor=1,Nombre="Fanta naranja"},
            new(){IdBase=4,IdCategoria=2, IdProveedor=2,Nombre="Pepsi"},
            new(){IdBase=5,IdCategoria=2, IdProveedor=2,Nombre="Rojita"},
            new(){IdBase=6,IdCategoria=2, IdProveedor=3,Nombre="Latitude E7440"}
        };

        return productsBase;
    }

    private IEnumerable<ProductoContenido> InitProductContent(){
        List<ProductoContenido> productsContents = new List<ProductoContenido>(){
            new(){IdContenido=1,Modelo="Articulo",Contenido="Unidad"},
            new(){IdContenido=2,Modelo="Retornable",Contenido="Litro"},
            new(){IdContenido=3,Modelo="Lata",Contenido="Mililitro"},
            new(){IdContenido=4,Modelo="Desechable",Contenido="Mililitro"},
            new(){IdContenido=5, Modelo="Desechable",Contenido="Litro"},
            new(){IdContenido=6, Modelo="Vidrio",Contenido="Mililitro"},
            new(){IdContenido=7,Modelo="Vidrio",Contenido="Litro"}
        };

        return productsContents;
    }

    private IEnumerable<Producto> InitProducts(){
        List<Producto> products = new List<Producto>(){
            new(){IdProducto=1,IdBase=1,IdContainer=2,Medida=2,Precio=38,UrlImagen="https://holymarket.cl/wp-content/uploads/2022/03/7801610001295-1.png",Existencia=10,Estado=EstadoCatalogo.Registrado},
            new(){IdProducto=2,IdBase=2,IdContainer=2,Medida=2,Precio=39,UrlImagen="https://docplayer.es/docs-images/109/187608361/images/12-3.jpg",Existencia=5,Estado=EstadoCatalogo.Registrado},
            new(){IdProducto=3,IdBase=3,IdContainer=2,Medida=2,Precio=39,UrlImagen="http://d2r9epyceweg5n.cloudfront.net/stores/001/160/839/products/005-004-011_fanta-retornable-x-2-lts1-67b8aab041082aa14315884684037152-640-0.jpg",Existencia=13,Estado=EstadoCatalogo.Registrado}
        };

        return products;
    }
}
