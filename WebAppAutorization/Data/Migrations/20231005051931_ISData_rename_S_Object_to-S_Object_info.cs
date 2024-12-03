using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_rename_S_Object_toS_Object_info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "S_Division_infos",
                columns: table => new
                {
                    id_division = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d1d04e2b-1866-4de4-815e-6348b13400ed", new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2012), "dff3a427-fc5a-4ab4-9b29-19eb7dc198f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b8460e98-a415-43cb-8635-53c44affb7cd", new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2052), "0e43fce9-cfd7-461b-886f-b004f5c26faa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "0f001a7b-5c4a-4090-9c02-dba3244c4b16", new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2072), "fe5fdf7d-e820-4796-b917-6f3c7800f73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "9e9fab29-5577-451d-9ac8-8b3a497ce686", new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 10, 5, 12, 19, 23, 556, DateTimeKind.Local).AddTicks(2080), "99a16fce-33e8-41cf-8345-113dfb1e8a99" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "S_Division_infos");

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
        }
    }
}
