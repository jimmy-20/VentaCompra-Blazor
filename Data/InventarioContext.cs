using Models;
using Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class InventarioContext : DbContext
{
    public DbSet<Category> TbCategory { get; set; }
    public DbSet<Provider> TbProvider { get; set; }
    public DbSet<BaseProduct> TbBaseProduct { get; set; }
    public DbSet<ContentProduct> TbContentProduct { get; set; }
    public DbSet<Product> TbProduct { get; set; }
    public DbSet<Customer> TbCustomer { get; set; }
    public DbSet<LegalCustomer> TbLegalCustomer { get; set; }
    public DbSet<NatureCustomer> TbNatureCustomer { get; set; }

    public InventarioContext(DbContextOptions<InventarioContext> options) :base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder option){
        if (!option.IsConfigured){
            option.UseSqlServer("Server=(local);Database=InventarioEF;Integrated Security=true;Encrypt=false");
        }
    }
    protected override void OnModelCreating(ModelBuilder builder){
        #region configuring_data_type
        //Cambiando los nvarchar a varchar(Configuracion masiva)
        foreach (var property in builder.Model.GetEntityTypes().SelectMany(entity => entity.GetDeclaredProperties().Where(property => property.ClrType == typeof(string))))
        {
            property.SetColumnType("varchar");
        }
        #endregion

        #region restrictions
        builder.Entity<Product>().Property(p => p.UrlImage).HasColumnType("nvarchar").HasMaxLength(1000);
        builder.Entity<NatureCustomer>().Property(p => p.Identification).HasColumnType("char");
        builder.Entity<LegalCustomer>().Property(p => p.Ruc).HasColumnType("char");
        builder.Entity<Provider>().Property(p => p.Ruc).HasColumnType("char");
        #endregion

        #region Seed_Data
        builder.Entity<Category>().HasData(InitCategory());
        builder.Entity<Provider>().HasData(InitProvider());
        builder.Entity<BaseProduct>().HasData(InitBaseProduct());
        builder.Entity<ContentProduct>().HasData(InitProductContent());
        builder.Entity<Product>().HasData(InitProducts());
        #endregion
    }

    private IEnumerable<Category> InitCategory(){
        List<Category> categories = new List<Category>(){
            new (){IdCategory=1,Name="Lacteos",Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new (){IdCategory=2, Name = "Bebidas carbonatadas",Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new (){IdCategory=3, Name="Aseo personal", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new (){IdCategory=4, Name="Aseo del hogar",Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new (){IdCategory=5, Name="Snacks", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new (){IdCategory=6, Name="Proteinas", Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"}
        };

        return categories;
    }

    private IEnumerable<Provider> InitProvider(){
        List<Provider> providers = new List<Provider>(){
            new(){IdProvider=1, Name="Coca Cola Company",Ruc="J0312010201321",Phone="22113355",Address="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new(){IdProvider=2, Name="Pepsi",Ruc="J0312010201322",Phone="88990123",Address="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"},
            new(){IdProvider=3, Name="Dell",Ruc="J0312010201323",Phone="78901010",Address="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"}
        };

        return providers;
    }

    private IEnumerable<BaseProduct> InitBaseProduct(){
        List<BaseProduct> productsBase = new List<BaseProduct>(){
            new(){IdBase = 1,IdCategory=2,IdProvider=1,Name="Coca cola"},
            new(){IdBase=2,IdCategory=2, IdProvider=1,Name="Fanta roja"},
            new(){IdBase=3,IdCategory=2, IdProvider=1,Name="Fanta naranja"},
            new(){IdBase=4,IdCategory=2, IdProvider=2,Name="Pepsi"},
            new(){IdBase=5,IdCategory=2, IdProvider=2,Name="Rojita"},
            new(){IdBase=6,IdCategory=2, IdProvider=3,Name="Latitude E7440"}
        };

        return productsBase;
    }

    private IEnumerable<ContentProduct> InitProductContent(){
        List<ContentProduct> productsContents = new List<ContentProduct>(){
            new(){IdContent=1,Model="Articulo",Content="Unidad"},
            new(){IdContent=2,Model="Retornable",Content="Litro"},
            new(){IdContent=3,Model="Lata",Content="Mililitro"},
            new(){IdContent=4,Model="Desechable",Content="Mililitro"},
            new(){IdContent=5, Model="Desechable",Content="Litro"},
            new(){IdContent=6, Model="Vidrio",Content="Mililitro"},
            new(){IdContent=7,Model="Vidrio",Content="Litro"}
        };

        return productsContents;
    }

    private IEnumerable<Product> InitProducts(){
        List<Product> products = new List<Product>(){
            new(){IdProduct=1,IdBase=1,IdContent=2,Volume=2,Price=38,UrlImage="https://holymarket.cl/wp-content/uploads/2022/03/7801610001295-1.png",Quantity=10,State=CatalogState.Register},
            new(){IdProduct=2,IdBase=2,IdContent=2,Volume=2,Price=39,UrlImage="https://docplayer.es/docs-images/109/187608361/images/12-3.jpg",Quantity=5,State=CatalogState.Register},
            new(){IdProduct=3,IdBase=3,IdContent=2,Volume=2,Price=39,UrlImage="http://d2r9epyceweg5n.cloudfront.net/stores/001/160/839/products/005-004-011_fanta-retornable-x-2-lts1-67b8aab041082aa14315884684037152-640-0.jpg",Quantity=13,State=CatalogState.Register}
        };

        return products;
    }
}
