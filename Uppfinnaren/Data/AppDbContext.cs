using System;
using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Data.Entities;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    public DbSet<ProductInfo> ProductInfos {get; set;} = null!;
    public DbSet<Category>Categories {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Category>().HasMany(e=>e.ProductInfos).WithOne().HasForeignKey(e=>e.CategoryId);
        modelBuilder.Entity<Category>().HasData(
            new Category {Id=1, Name="Möbler"},
            new Category {Id=2, Name="Teknik"},
            new Category {Id=3, Name="Bakverk"},
            new Category {Id=4, Name="Lego"},
            new Category {Id=5, Name="LifeHacks"}
        );
        

        modelBuilder.Entity<ProductInfo>().HasData(
            new ProductInfo {Id=1, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=2, Type="Bord", Color="Grå", Material="Gjutjärn", Description="Ett bord jag byggde ifrån en massa gjutjärnsgrytor", Name = "Bord", CategoryId=1},
            new ProductInfo {Id=3, Type="Datorchassi", Color="Svart", Material="Gummi", Description="Ett Datorchassi som är byggt av ett traktordäck", Name = "Chassi", CategoryId=2},
            new ProductInfo {Id=4, Type="Bulle", Color="Brun", Material="Bröd", Description="En bulle an bröd", Name = "Bulle", CategoryId=3},
            new ProductInfo {Id=5, Type="Legobygge", Color="Blandad", Material="Lego", Description="En dödsstjärna av lego", Name = "LegoDeathstar", CategoryId=4},
            new ProductInfo {Id=6, Type="Legobygge", Color="Gul", Material="Lego", Description="En anka byggd med lego", Name = "Legoanka", CategoryId=4},
            new ProductInfo {Id=7, Type="Legobygge", Color="Blandad", Material="Lego", Description="En R2D2 byggd med lego", Name = "LegoR2D2", CategoryId=4},
            new ProductInfo {Id=8, Type="Legobygge", Color="Blandad", Material="Lego", Description="En C-3PO byggs med lego", Name = "LegoC3PO", CategoryId=4},
            new ProductInfo {Id=9, Type="Tårta", Color="Blandad", Material="Grädde", Description="En facecake jag gjorde av min sambo", Name = "Facecake", CategoryId=3},
            new ProductInfo {Id=10, Type="Hallmöbel", Color="Brun", Material="Trä", Description="En hallmöbel jag gjorde av ett gammalt ryggstöd", Name = "Hallmöbel", CategoryId=1},
            new ProductInfo {Id=11, Type="Kaka", Color="Brun", Material="daim", Description="En daimkaka jag gjorde till ett dop", Name = "Daimkaka", CategoryId=3},
            new ProductInfo {Id=12, Type="Stol", Color="Grå", Material="Metall", Description="En stol jag byggde av en dörr till en Amazon", Name = "Metalstol", CategoryId=1},
            new ProductInfo {Id=13, Type="Kaka", Color="Brun", Material="Bröd", Description="En kaka gjord på morot", Name = "Morotskaka", CategoryId=3},
            new ProductInfo {Id=14, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=15, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=16, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=17, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=18, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=19, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1},
            new ProductInfo {Id=20, Type="Stol", Color="Natur", Material="Trä", Description="En stol jag byggde ifrån en stubbe", Name = "Stol", CategoryId=1}

        );
    }
}
