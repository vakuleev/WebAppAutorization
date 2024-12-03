using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class factorysatelitstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                schema: "isdata",
                table: "S_Factory_info",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8e9a51a0-65da-412e-86ea-e784315463c3", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6359), "8f83779a-d75d-421c-a98e-f3119f909855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6afc8f02-3980-4271-aa92-1029bed1aa98", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6399), "64f21198-2e4e-4128-889d-e689d1616b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "97dc48ec-ab47-46bd-a277-c2034053240f", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6417), "e864bdf0-2027-4fd6-ae41-56eadebe14d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7f339914-82cc-4ce6-9475-1eb5afab1f5c", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6425), "6691d174-5214-4006-8167-ab3e4771ca0b" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "0297c3fa-3422-4c71-92c0-69f40edce9c5", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1531), "216de533-70b5-4d5f-b1dd-e3fc1f01591c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "420e44b5-8d86-4da6-8321-e0643388e96b", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1569), "256e314f-6720-4c53-9f9f-a13207bf40fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7fc8c89e-b8ed-4204-91d8-12b5de4814c6", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1587), "ca83e69d-781d-40fa-9237-e356e5527595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "fcbea1f9-02c9-4f2a-91e6-b53c1a69ea48", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1595), "e4992534-4175-44c5-8b4a-daa3ec167636" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
