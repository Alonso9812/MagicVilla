using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa", new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2564), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la Villa", new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2579), "", 100, "Villa Premiun", 10, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
