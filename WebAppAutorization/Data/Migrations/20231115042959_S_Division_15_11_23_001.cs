using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_Division_15_11_23_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "26007816-b2fe-4d5e-98d3-8c306eca9dd6", new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1601), "f86809a8-d284-4d12-aa33-05a31cdc1722" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e15b7272-7982-46a4-bb22-826104168d7f", new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1717), "5d2dac8a-ed24-498e-9153-95021d4f5d46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "22aef6a2-46b9-48a4-a58f-c9649746c168", new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1738), new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1737), "98873766-af41-4a26-a8f9-b9311b1e3211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4e2f0486-66da-4fc2-955c-e49a333bdc58", new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 11, 15, 10, 27, 30, 282, DateTimeKind.Local).AddTicks(1746), "73c3c524-8384-4145-b7ac-4ae1889e269f" });
        }
    }
}
