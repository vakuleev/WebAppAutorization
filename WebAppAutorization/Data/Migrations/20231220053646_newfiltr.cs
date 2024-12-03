using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfiltr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResName",
                table: "AspNetUsers",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ViewAllRes",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "ResName", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "c353cf0f-1b44-40e3-aeff-5386c8ddbbb1", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(1728), null, "8a6a3dd6-b98c-490c-a782-e8e24460ada2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "ResName", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b6a64dc4-f19b-42bd-ba60-4152bdd75cba", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2014), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2012), null, "e038b75a-3cd7-40e0-ba8a-2bfc33c0f4f8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "ResName", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b8d652b0-98a5-4241-b4b1-93f38f87ae22", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2034), null, "225238df-aab2-44a4-9312-ac3038d84187", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "ResName", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b71b10f9-77b5-4b9f-b6a3-ed7218f4a54d", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2042), null, "963fd81e-9a0f-4c15-95d7-701be2008460", null });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ProductStoim", "SumNalog", "SumProductNalog" },
                values: new object[] { 1059593.04m, 211918.61m, 1271511.65m });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ViewAllRes",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "76fcb8a2-4dfb-4a26-b639-75849b27e93f", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4937), "68884cb4-cce6-452d-9c8d-5ba4d9d23faf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8c755d60-1092-41d5-90ae-33a295698dff", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4979), "eb8678c3-e118-408c-a677-b7231b68665e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1f3174cc-9c64-4646-9a10-ffee0a914a98", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4997), "bfff3639-d58a-4584-8c73-328e7b22a26d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "86387121-4db4-42b3-bd23-6e8d806aad5c", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(5005), "9b4866fd-efcb-411b-8a2e-5a52b7224127" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ProductStoim", "SumNalog", "SumProductNalog" },
                values: new object[] { 1059593.03m, 211918.6m, 1271511.63m });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
