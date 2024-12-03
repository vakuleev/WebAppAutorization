using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_Factory_info_key_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "c44473db-c951-47cf-b7fd-16915c03febc", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6177), "7cefd53f-a5dd-43d4-8558-42212ff3f217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "3f05a2d3-ade4-47ed-8c93-af7e8a325acb", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6210), "6962875e-9f2e-4b9b-9bf8-cd596a347e32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "41ada749-3bce-4ac2-ba36-d69f47acbf0f", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6231), "ffc5e120-ecba-495a-83f3-228abe3c6d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "87a24c7a-2c16-4f9c-9b08-2aff12ebe71e", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6239), "f2febdfb-832a-4493-917b-3d436d9f218a" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Factory_info",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ce77f364-a48a-43f2-8afb-d8d4e352db0d", new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1789), "4a2da8db-5afc-4fea-a978-a08388871aa9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "9afe98a2-9fb3-4168-bf85-994146f307f2", new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1828), "e29d5e8c-1adb-4d4d-89c9-e2207b662223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d28067a1-3410-4ce5-877c-dfe3eabe1d80", new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1848), new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1847), "3909006f-04a7-4a37-bc9b-3b1897ae0b96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e06bb0dc-0a3a-4b0d-b208-10757b1e100c", new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 11, 15, 12, 34, 20, 809, DateTimeKind.Local).AddTicks(1855), "100f61b7-9f71-4f57-89c3-13b01440f2d3" });

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
    }
}
