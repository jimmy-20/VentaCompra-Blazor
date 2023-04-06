using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AgregandocamposdefechasdeactualizaciónycambiandoelnombredelatablaMovement_DetailaTransaction_Detail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 1,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 2,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "IdProduct",
                keyValue: 3,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "IdProvider",
                keyValue: 1,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "IdProvider",
                keyValue: 2,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Provider",
                keyColumn: "IdProvider",
                keyValue: 3,
                column: "DateUpdate",
                value: new DateTime(2023, 4, 5, 18, 42, 7, 215, DateTimeKind.Local).AddTicks(1017));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Provider");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DateUpdate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customer");
        }
    }
}
