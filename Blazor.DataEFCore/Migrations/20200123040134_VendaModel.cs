using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataEFCore.Migrations
{
    public partial class VendaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    VendaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroNotaFiscal = table.Column<string>(nullable: false),
                    DataNF = table.Column<DateTime>(nullable: false),
                    NomeCliente = table.Column<string>(nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ValorCompra = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    PercentualImposto = table.Column<double>(nullable: false),
                    ValorFrete1 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ValorFrete2 = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    PercentualCustoOperacional = table.Column<double>(nullable: false),
                    ValorOutrasDespesas = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ValorCustoTotal = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    PercentualComissao = table.Column<double>(nullable: false),
                    ValorComissao = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    PercentualLucro = table.Column<double>(nullable: false),
                    ValorLucro = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.VendaId);
                });

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 23, 1, 1, 33, 732, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 26, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 29, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 23, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 2, 6, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 3, 23, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 23, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 2, 25, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 4, 11, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 23, 1, 1, 33, 734, DateTimeKind.Local).AddTicks(2986));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 8, 2, 30, 0, 849, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 11, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 14, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 8, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 22, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 3, 8, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 8, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 2, 10, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 3, 27, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 8, 2, 30, 0, 850, DateTimeKind.Local).AddTicks(8718));
        }
    }
}
