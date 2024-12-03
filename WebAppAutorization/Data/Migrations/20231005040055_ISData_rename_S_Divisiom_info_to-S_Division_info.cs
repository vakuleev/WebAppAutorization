using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_rename_S_Divisiom_info_toS_Division_info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "85d46952-acd4-4001-ba80-94b40f81329b", new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(6995), "c89101e3-39c6-4a73-843d-136644ec18cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "81fc0227-7e6a-4e5f-a85e-af7e1e150c5a", new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7066), new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7065), "94974578-d769-4d4e-85f0-d03a2a122e7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "844dd5c3-0209-4a7c-b473-235040f4369a", new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7085), new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7084), "f9dfd5fe-5ba0-41a8-a37f-29fa02fd48ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f56effbb-d8cc-4cbd-9076-136438fcb21f", new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7094), new DateTime(2023, 10, 5, 11, 0, 47, 28, DateTimeKind.Local).AddTicks(7093), "4f46b1b0-fe75-4eba-8a05-1ac9919bcdc3" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
