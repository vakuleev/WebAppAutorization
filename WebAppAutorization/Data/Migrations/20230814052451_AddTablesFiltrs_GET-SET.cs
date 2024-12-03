using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesFiltrs_GETSET : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateFiltrEnd",
                schema: "datalab",
                table: "DataFiltrs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFiltrStart",
                schema: "datalab",
                table: "DataFiltrs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea03fc02-abc6-498a-a7a2-ebd52fa6e1fa", "50562cd6-9119-443c-881c-a1e43325b909" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "246f80c9-1a38-42d3-8a92-72f6766eed54", "fb4592b9-f1f1-40d0-8634-76b331615b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4796fbb1-154c-43da-b62e-be6b87f8394a", "7a193c25-b2bf-4ac1-9647-701886e19de4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a788f26-78e3-42e3-b073-d8f1381320b2", "06cf293c-b3d6-4bac-b603-aec4d83ab5c3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFiltrEnd",
                schema: "datalab",
                table: "DataFiltrs");

            migrationBuilder.DropColumn(
                name: "DateFiltrStart",
                schema: "datalab",
                table: "DataFiltrs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe0aec52-640c-42c9-844a-a7fa7870f54b", "59d97584-f048-49d7-b511-74a034304d52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8d06ced-fc58-468f-903b-45d93a8ef646", "90c73b85-aef7-4787-8d07-13f2ced97896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df700150-a5ed-4ae3-be2f-844736c894ab", "fbb4c2e5-b467-4a97-a516-d64ae752137a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d29115d-63c7-4770-b355-5ca5155946ec", "32b42cc0-4b45-4e46-8228-0b6e6fb4e637" });
        }
    }
}
