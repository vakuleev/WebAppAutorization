using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_Factory_15_11_23_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
