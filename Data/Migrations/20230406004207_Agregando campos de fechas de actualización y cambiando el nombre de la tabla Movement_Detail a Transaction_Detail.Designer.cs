﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(InventarioContext))]
    [Migration("20230406004207_Agregando campos de fechas de actualización y cambiando el nombre de la tabla Movement_Detail a Transaction_Detail")]
    partial class AgregandocamposdefechasdeactualizaciónycambiandoelnombredelatablaMovement_DetailaTransaction_Detail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("EmployeeSequence");

            modelBuilder.HasSequence("OrderSequence");

            modelBuilder.HasSequence("PurchaseSequence");

            modelBuilder.Entity("Models.BaseProduct", b =>
                {
                    b.Property<int>("IdBase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBase"));

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdProvider")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("IdBase");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdProvider");

                    b.ToTable("BaseProduct");

                    b.HasData(
                        new
                        {
                            IdBase = 1,
                            IdCategory = 2,
                            IdProvider = 1,
                            Name = "Coca cola"
                        },
                        new
                        {
                            IdBase = 2,
                            IdCategory = 2,
                            IdProvider = 1,
                            Name = "Fanta roja"
                        },
                        new
                        {
                            IdBase = 3,
                            IdCategory = 2,
                            IdProvider = 1,
                            Name = "Fanta naranja"
                        },
                        new
                        {
                            IdBase = 4,
                            IdCategory = 2,
                            IdProvider = 2,
                            Name = "Pepsi"
                        },
                        new
                        {
                            IdBase = 5,
                            IdCategory = 2,
                            IdProvider = 2,
                            Name = "Rojita"
                        },
                        new
                        {
                            IdBase = 6,
                            IdCategory = 2,
                            IdProvider = 3,
                            Name = "Latitude E7440"
                        });
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("IdCategory");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            IdCategory = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Lacteos"
                        },
                        new
                        {
                            IdCategory = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Bebidas carbonatadas"
                        },
                        new
                        {
                            IdCategory = 3,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Aseo personal"
                        },
                        new
                        {
                            IdCategory = 4,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Aseo del hogar"
                        },
                        new
                        {
                            IdCategory = 5,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Snacks"
                        },
                        new
                        {
                            IdCategory = 6,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            Name = "Proteinas"
                        });
                });

            modelBuilder.Entity("Models.ContentProduct", b =>
                {
                    b.Property<int>("IdContent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContent"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.HasKey("IdContent");

                    b.ToTable("ContentProduct");

                    b.HasData(
                        new
                        {
                            IdContent = 1,
                            Content = "Unidad",
                            Model = "Articulo"
                        },
                        new
                        {
                            IdContent = 2,
                            Content = "Litro",
                            Model = "Retornable"
                        },
                        new
                        {
                            IdContent = 3,
                            Content = "Mililitro",
                            Model = "Lata"
                        },
                        new
                        {
                            IdContent = 4,
                            Content = "Mililitro",
                            Model = "Desechable"
                        },
                        new
                        {
                            IdContent = 5,
                            Content = "Litro",
                            Model = "Desechable"
                        },
                        new
                        {
                            IdContent = 6,
                            Content = "Mililitro",
                            Model = "Vidrio"
                        },
                        new
                        {
                            IdContent = 7,
                            Content = "Litro",
                            Model = "Vidrio"
                        });
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCustomer"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("IdCustomer");

                    b.ToTable("Customer");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [EmployeeSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("CatalogState")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstLastName")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("SecondLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [OrderSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<int>("MovementType")
                        .HasColumnType("int");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<double>("SubAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdEmployee");

                    b.ToTable("Order");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Models.Order_Detail", b =>
                {
                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdOrder", "IdProduct");

                    b.HasIndex("IdProduct");

                    b.ToTable("OrderDetail");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"));

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdBase")
                        .HasColumnType("int");

                    b.Property<int>("IdContent")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdBase");

                    b.HasIndex("IdContent");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            IdProduct = 1,
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1124),
                            IdBase = 1,
                            IdContent = 2,
                            Price = 38.0,
                            Quantity = 10,
                            State = 1,
                            UrlImage = "https://holymarket.cl/wp-content/uploads/2022/03/7801610001295-1.png",
                            Volume = 2.0
                        },
                        new
                        {
                            IdProduct = 2,
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1129),
                            IdBase = 2,
                            IdContent = 2,
                            Price = 39.0,
                            Quantity = 5,
                            State = 1,
                            UrlImage = "https://docplayer.es/docs-images/109/187608361/images/12-3.jpg",
                            Volume = 2.0
                        },
                        new
                        {
                            IdProduct = 3,
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1131),
                            IdBase = 3,
                            IdContent = 2,
                            Price = 39.0,
                            Quantity = 13,
                            State = 1,
                            UrlImage = "http://d2r9epyceweg5n.cloudfront.net/stores/001/160/839/products/005-004-011_fanta-retornable-x-2-lts1-67b8aab041082aa14315884684037152-640-0.jpg",
                            Volume = 2.0
                        });
                });

            modelBuilder.Entity("Models.Provider", b =>
                {
                    b.Property<int>("IdProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProvider"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar");

                    b.Property<string>("Ruc")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("IdProvider");

                    b.ToTable("Provider");

                    b.HasData(
                        new
                        {
                            IdProvider = 1,
                            Address = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1000),
                            Name = "Coca Cola Company",
                            Phone = "22113355",
                            Ruc = "J0312010201321",
                            State = 1
                        },
                        new
                        {
                            IdProvider = 2,
                            Address = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1015),
                            Name = "Pepsi",
                            Phone = "88990123",
                            Ruc = "J0312010201322",
                            State = 1
                        },
                        new
                        {
                            IdProvider = 3,
                            Address = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's",
                            DateUpdate = new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1017),
                            Name = "Dell",
                            Phone = "78901010",
                            Ruc = "J0312010201323",
                            State = 1
                        });
                });

            modelBuilder.Entity("Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [PurchaseSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("IdProvider")
                        .HasColumnType("int");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<int>("MovementType")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseState")
                        .HasColumnType("int");

                    b.Property<double>("SubAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdProvider");

                    b.ToTable("Purchase");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Models.Purchase_Detail", b =>
                {
                    b.Property<int>("IdPurchase")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdPurchase", "IdProduct");

                    b.HasIndex("IdProduct");

                    b.ToTable("PurchaseDetail");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Models.LegalCustomer", b =>
                {
                    b.HasBaseType("Models.Customer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Ruc")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char");

                    b.ToTable("LegalCustomer");
                });

            modelBuilder.Entity("Models.NatureCustomer", b =>
                {
                    b.HasBaseType("Models.Customer");

                    b.Property<string>("FirstLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("char");

                    b.Property<string>("SecondLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.ToTable("NatureCustomer");
                });

            modelBuilder.Entity("Models.BaseProduct", b =>
                {
                    b.HasOne("Models.Category", "Category")
                        .WithMany("BaseProducts")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Provider", "Provider")
                        .WithMany("BaseProducts")
                        .HasForeignKey("IdProvider")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Models.Order_Detail", b =>
                {
                    b.HasOne("Models.Order", "Order")
                        .WithMany("Order_Details")
                        .HasForeignKey("IdOrder")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Models.Product", "Product")
                        .WithMany("Order_Details")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.HasOne("Models.BaseProduct", "BaseProduct")
                        .WithMany("Products")
                        .HasForeignKey("IdBase")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.ContentProduct", "ContentProduct")
                        .WithMany("Products")
                        .HasForeignKey("IdContent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaseProduct");

                    b.Navigation("ContentProduct");
                });

            modelBuilder.Entity("Models.Purchase", b =>
                {
                    b.HasOne("Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("IdProvider")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Models.Purchase_Detail", b =>
                {
                    b.HasOne("Models.Product", "Product")
                        .WithMany("Purchase_Details")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Models.Purchase", "Purchase")
                        .WithMany("Purchase_Details")
                        .HasForeignKey("IdPurchase")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("Models.LegalCustomer", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithOne("LegalCustomer")
                        .HasForeignKey("Models.LegalCustomer", "IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Models.NatureCustomer", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithOne("NatureCustomer")
                        .HasForeignKey("Models.NatureCustomer", "IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Models.BaseProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Navigation("BaseProducts");
                });

            modelBuilder.Entity("Models.ContentProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Navigation("LegalCustomer")
                        .IsRequired();

                    b.Navigation("NatureCustomer")
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("Order_Details");

                    b.Navigation("Purchase_Details");
                });

            modelBuilder.Entity("Models.Provider", b =>
                {
                    b.Navigation("BaseProducts");
                });

            modelBuilder.Entity("Models.Purchase", b =>
                {
                    b.Navigation("Purchase_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
