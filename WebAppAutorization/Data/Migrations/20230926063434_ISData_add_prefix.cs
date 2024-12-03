using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_add_prefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_object",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_eemp",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_Division",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prefix",
                schema: "isdata",
                table: "H_object");

            migrationBuilder.DropColumn(
                name: "prefix",
                schema: "isdata",
                table: "H_eemp");

            migrationBuilder.DropColumn(
                name: "prefix",
                schema: "isdata",
                table: "H_Division");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e9330509-19c9-4e4b-92dd-118a5b11d385", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5078), "d95765ec-6d46-4b90-904d-80be5b3f8f38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "117f2ab6-1276-439a-ae33-1ac6576a4b3a", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5114), "a4329277-87f1-499a-81b6-1e39ca05eb18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1c325acf-46ea-4824-8244-e810c4022d6b", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5134), "a7ad328a-198a-4563-b2bf-269e2ce2fb86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "af3c3d11-cde3-442d-9c61-cf95b58f27da", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5142), "42101876-c6e0-4f50-8526-6d1b528155ea" });
        }
    }
}
