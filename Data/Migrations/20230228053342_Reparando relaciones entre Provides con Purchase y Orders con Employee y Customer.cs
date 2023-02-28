using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ReparandorelacionesentreProvidesconPurchaseyOrdersconEmployeeyCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SecondLastName",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_IdProvider",
                table: "Purchase",
                column: "IdProvider");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdCustomer",
                table: "Order",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Order_IdEmployee",
                table: "Order",
                column: "IdEmployee");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_IdCustomer",
                table: "Order",
                column: "IdCustomer",
                principalTable: "Customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_IdEmployee",
                table: "Order",
                column: "IdEmployee",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Provider_IdProvider",
                table: "Purchase",
                column: "IdProvider",
                principalTable: "Provider",
                principalColumn: "IdProvider",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_IdCustomer",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_IdEmployee",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Provider_IdProvider",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_IdProvider",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Order_IdCustomer",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_IdEmployee",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "SecondName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SecondLastName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
