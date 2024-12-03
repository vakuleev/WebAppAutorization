using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_S_Division_PK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "S_Division_infos",
                newName: "S_Division_info",
                newSchema: "isdata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info",
                column: "id_division");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6df9d5e9-0f82-4f9f-893a-d0bb79a4034a", new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8235), new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8218), "0bedeb0d-fd0d-4ba7-ac16-8e1c39508aea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "afdac5d3-019a-48eb-a968-b8ec11ff697e", new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8256), "44435883-2414-4286-b663-96628a164640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d392c8af-3150-45c4-b254-1cb54f823ee7", new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8273), new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8272), "b4d8f3b2-61bf-4cb2-898e-69c6ea389ce2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7fd49b4e-c7df-465b-ac05-96d4755eeb43", new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 10, 5, 15, 7, 17, 301, DateTimeKind.Local).AddTicks(8281), "9a7b08dd-9405-4059-9b7f-67207ad7f607" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.RenameTable(
                name: "S_Division_info",
                schema: "isdata",
                newName: "S_Division_infos");

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
    }
}
