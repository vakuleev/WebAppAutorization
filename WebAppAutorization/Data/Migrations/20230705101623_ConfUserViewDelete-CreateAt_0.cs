using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfUserViewDeleteCreateAt_0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                schema: "data",
                table: "Sheetfs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a228d8bf-d383-49cd-9849-1a3edc873ff7", "e70d71f3-180f-4f4f-8a0f-f6609d4551e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bab9c7ae-f6f6-468d-b02b-f438cb1879a0", "4fc220dc-0eb3-4d58-8a42-f167ade7f45d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "281f115d-6975-4176-aac7-86b013d7350a", "9fdde179-68fb-427f-bf1c-1cd0643a3f7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f31a6bee-e60b-45f7-9f17-db023d59e84f", "ebae8c41-6220-45c2-b4df-d1d044e6d6f7" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                schema: "data",
                table: "Sheetfs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4d91f88-7f6d-4f9a-b4ef-4ef61b615a81", "c341ca03-f701-445c-8023-13f6675000e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2093d50-c38d-4d99-acb3-8eaa52e1b2a9", "8409dd98-c1ce-4526-b27b-ea4d73389069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f008738-b75c-4ca9-85d0-38a19993ad23", "7756452e-e082-4df2-bf04-11fbbbfd875d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "840332ab-43c0-4c98-b4f6-e794234aea4d", "5e93b90b-cbbd-4be3-87a8-5d7c0c927b07" });
        }
    }
}
