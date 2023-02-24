using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    IdCategory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "ContentProduct",
                columns: table => new
                {
                    IdContent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentProduct", x => x.IdContent);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Address = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.IdCustomer);
                });

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    IdProvider = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Ruc = table.Column<string>(type: "char(14)", maxLength: 14, nullable: false),
                    Phone = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Address = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.IdProvider);
                });

            migrationBuilder.CreateTable(
                name: "LegalCustomer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Ruc = table.Column<string>(type: "char(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalCustomer", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_LegalCustomer_Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NatureCustomer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FirstLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SecondLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Identification = table.Column<string>(type: "char(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureCustomer", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_NatureCustomer_Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseProduct",
                columns: table => new
                {
                    IdBase = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategory = table.Column<int>(type: "int", nullable: false),
                    IdProvider = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProduct", x => x.IdBase);
                    table.ForeignKey(
                        name: "FK_BaseProduct_CategoryProduct_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "CategoryProduct",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseProduct_Provider_IdProvider",
                        column: x => x.IdProvider,
                        principalTable: "Provider",
                        principalColumn: "IdProvider",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBase = table.Column<int>(type: "int", nullable: false),
                    IdContent = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_Product_BaseProduct_IdBase",
                        column: x => x.IdBase,
                        principalTable: "BaseProduct",
                        principalColumn: "IdBase",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ContentProduct_IdContent",
                        column: x => x.IdContent,
                        principalTable: "ContentProduct",
                        principalColumn: "IdContent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "IdCategory", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Lacteos" },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Bebidas carbonatadas" },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Aseo personal" },
                    { 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Aseo del hogar" },
                    { 5, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Snacks" },
                    { 6, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", "Proteinas" }
                });

            migrationBuilder.InsertData(
                table: "ContentProduct",
                columns: new[] { "IdContent", "Content", "Model" },
                values: new object[,]
                {
                    { 1, "Unidad", "Articulo" },
                    { 2, "Litro", "Retornable" },
                    { 3, "Mililitro", "Lata" },
                    { 4, "Mililitro", "Desechable" },
                    { 5, "Litro", "Desechable" },
                    { 6, "Mililitro", "Vidrio" },
                    { 7, "Litro", "Vidrio" }
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "IdProvider", "Address", "Email", "Name", "Phone", "Ruc", "State" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", null, "Coca Cola Company", "22113355", "J0312010201321", 1 },
                    { 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", null, "Pepsi", "88990123", "J0312010201322", 1 },
                    { 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's", null, "Dell", "78901010", "J0312010201323", 1 }
                });

            migrationBuilder.InsertData(
                table: "BaseProduct",
                columns: new[] { "IdBase", "IdCategory", "IdProvider", "Name" },
                values: new object[,]
                {
                    { 1, 2, 1, "Coca cola" },
                    { 2, 2, 1, "Fanta roja" },
                    { 3, 2, 1, "Fanta naranja" },
                    { 4, 2, 2, "Pepsi" },
                    { 5, 2, 2, "Rojita" },
                    { 6, 2, 3, "Latitude E7440" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "IdProduct", "IdBase", "IdContent", "Price", "Quantity", "State", "UrlImage", "Volume" },
                values: new object[,]
                {
                    { 1, 1, 2, 38.0, 10, 1, "https://holymarket.cl/wp-content/uploads/2022/03/7801610001295-1.png", 2.0 },
                    { 2, 2, 2, 39.0, 5, 1, "https://docplayer.es/docs-images/109/187608361/images/12-3.jpg", 2.0 },
                    { 3, 3, 2, 39.0, 13, 1, "http://d2r9epyceweg5n.cloudfront.net/stores/001/160/839/products/005-004-011_fanta-retornable-x-2-lts1-67b8aab041082aa14315884684037152-640-0.jpg", 2.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseProduct_IdCategory",
                table: "BaseProduct",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_BaseProduct_IdProvider",
                table: "BaseProduct",
                column: "IdProvider");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IdBase",
                table: "Product",
                column: "IdBase");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IdContent",
                table: "Product",
                column: "IdContent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalCustomer");

            migrationBuilder.DropTable(
                name: "NatureCustomer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "BaseProduct");

            migrationBuilder.DropTable(
                name: "ContentProduct");

            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Provider");
        }
    }
}
