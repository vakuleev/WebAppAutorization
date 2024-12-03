using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "a580f225-1865-4fb9-9449-3993da2c9750", new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1462), "4f044e2b-929e-4cd7-83b5-846a597b5aa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1e024b53-fe84-4879-a97f-537d5a26625e", new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1557), new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1557), "2d3a0479-26af-4f9d-b23f-4762db6f5e26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "a6533db6-9776-4907-ba37-448c743e07b2", new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1575), "da554c95-2336-4d29-8e59-32cdfd669b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8bc66b1e-5dbe-4464-8a9a-74a290e0081a", new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 9, 30, 18, 9, 56, 626, DateTimeKind.Local).AddTicks(1584), "e1c7372f-3beb-4412-a518-e3be1ff87fea" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d911ed52-a834-481a-804b-0d40327f2a03", new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1456), "2b6a1a2c-7352-49a9-9304-501bce385ee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e30493ab-bfea-4b82-add9-c9cc4d4584ca", new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1575), "24328c44-8970-40c0-81dc-0a19ee794eda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "a29a79a1-5010-4efa-a6f4-0c395d73b5bb", new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1593), "15e71cbf-c371-4e10-8f43-14840c688d5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "84861ba3-58a0-441c-9ba8-93b39ac4bfc3", new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 9, 26, 13, 34, 28, 400, DateTimeKind.Local).AddTicks(1601), "c8857b6f-f185-44f7-8c8e-a092b55d1a91" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
