using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataEFCore.Migrations
{
    public partial class updatetypepercentualcomissao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PercentualComissao",
                table: "Venda",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 9, 1, 28, 58, 451, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 4, 12, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 4, 15, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 4, 9, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 4, 23, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 8, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 4, 9, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 12, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 27, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 4, 9, 1, 28, 58, 453, DateTimeKind.Local).AddTicks(2483));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PercentualComissao",
                table: "Venda",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 4, 6, 14, 44, 27, 26, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 4, 9, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 4, 12, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 4, 6, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 4, 20, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 6, 5, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 4, 6, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 5, 9, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 6, 24, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "WeatherForecast",
                keyColumn: "WeatherForecastId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 4, 6, 14, 44, 27, 27, DateTimeKind.Local).AddTicks(9625));
        }
    }
}
