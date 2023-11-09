using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class initialParcial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conceptos",
                columns: table => new
                {
                    ConceptoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conceptos", x => x.ConceptoId);
                });

            migrationBuilder.CreateTable(
                name: "LibrosContables",
                columns: table => new
                {
                    LibroContableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CapitalActual = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrosContables", x => x.LibroContableId);
                });

            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    AsientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConceptoId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    TipoAsiento = table.Column<int>(type: "int", nullable: false),
                    LibroContableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.AsientoId);
                    table.ForeignKey(
                        name: "FK_Asientos_Conceptos_ConceptoId",
                        column: x => x.ConceptoId,
                        principalTable: "Conceptos",
                        principalColumn: "ConceptoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asientos_LibrosContables_LibroContableId",
                        column: x => x.LibroContableId,
                        principalTable: "LibrosContables",
                        principalColumn: "LibroContableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Conceptos",
                columns: new[] { "ConceptoId", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Compra de insumos para la elaboracion de los platos", "Compra de insumos" },
                    { 2, "Venta de insumos para la elaboracion de los platos", "Venta de insumos" },
                    { 3, "", "Depreciación de activos fijos" },
                    { 4, "", "Pago de intereses" },
                    { 5, "", "Venta de productos terminados" }
                });

            migrationBuilder.InsertData(
                table: "LibrosContables",
                columns: new[] { "LibroContableId", "CapitalActual", "MesYear" },
                values: new object[] { 1, 10000, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "AsientoId", "Codigo", "ConceptoId", "Fecha", "LibroContableId", "Monto", "TipoAsiento" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000, 0 },
                    { 2, 2, 2, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2000, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_Codigo",
                table: "Asientos",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_ConceptoId",
                table: "Asientos",
                column: "ConceptoId");

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_LibroContableId",
                table: "Asientos",
                column: "LibroContableId");

            migrationBuilder.CreateIndex(
                name: "IX_Conceptos_Nombre",
                table: "Conceptos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibrosContables_MesYear",
                table: "LibrosContables",
                column: "MesYear",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "Conceptos");

            migrationBuilder.DropTable(
                name: "LibrosContables");
        }
    }
}
