using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_Factory_15_11_23_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e18cd9ae-61a9-44ef-82fc-75d365a66bb5", new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1549), "eb392d72-41bb-430b-9af4-cd0b976e524a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4dbd38ba-8d9d-47e5-8ecd-ec7a5088e7d8", new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1586), "77d09127-146f-4939-acf0-5f2bd87d5081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "c5ef61b0-76c5-4c84-a72b-0da8e47512a1", new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1605), "37363438-1469-4663-b707-8b63bdf15af6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "9ca87af0-8b8b-43b0-99ca-a782e17acdff", new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 11, 15, 11, 45, 15, 555, DateTimeKind.Local).AddTicks(1613), "3d1c1e38-71ef-4b42-9702-6101deeff070" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f2bda631-b921-481d-bbe7-38a58e0ec61b", new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2554), "8ab053dd-1c35-4ea8-b8c8-8cf548532c2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "817660ae-e4b5-49e3-8971-227ee2de1ab8", new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2590), "752ab8cf-0d73-4b8b-9736-dbfae632021e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "3db53935-67c2-4129-92b3-de11250cf2a7", new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2613), "ab1de724-c089-420e-9cba-7f641548bb94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "a05a2c52-a975-4462-ab79-7ee0bfc0d184", new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 11, 15, 11, 29, 54, 699, DateTimeKind.Local).AddTicks(2622), "fe3b4374-8ef6-40dc-b89f-a1728baf4748" });
        }
    }
}
