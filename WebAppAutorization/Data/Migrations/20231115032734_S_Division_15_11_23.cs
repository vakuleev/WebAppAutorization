using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_Division_15_11_23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "23640765-98e4-4450-991b-fdf677010389", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8532), "ec8eef75-b279-41af-a50f-9db9cddac520" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7631b0f8-57c1-4f0f-8f24-2fc1ca1fd8d3", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8573), "bcea2161-b2d6-4cd9-8cc9-f79f7830c203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8e2a290a-ec66-47de-9691-921d04639f15", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8623), "226037b5-2bd4-4ed6-8748-4ff51d6857c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "84937516-7d65-4e58-b83d-7280c5af5185", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8633), "44d0591f-b170-4d14-83b8-1227c7295f64" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
