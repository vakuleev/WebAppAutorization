using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_shema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "I_object_eemp",
                newName: "I_object_eemp",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "I_Factory_eemp",
                newName: "I_Factory_eemp",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "I_Factory_Division",
                newName: "I_Factory_Division",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "I_division_object",
                newName: "I_division_object",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "I_Division_eemp",
                newName: "I_Division_eemp",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_object",
                newName: "H_object",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_Factory",
                newName: "H_Factory",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_eemp",
                newName: "H_eemp",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_Division",
                newName: "H_Division",
                newSchema: "isdata");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4e2b7e04-39d7-4eab-917c-2a68792feba2", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7330), "58b8e01f-fed9-4f75-ac15-4d105fc4a42c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e15b31a6-8732-4fc2-825b-dca8ab0b49b7", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7366), "17849a3f-bcc4-421d-aefb-5127e526c906" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1a7aef5b-a7a6-4006-b2e9-7940e0a2e01b", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7385), "f8b66436-efea-41d0-8332-5f03087a1259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "bd67192e-c5d3-4b00-aaed-b2e8958fd6ea", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7393), "476871ca-b4c1-4951-a956-fdc8431d52b7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "I_object_eemp",
                schema: "isdata",
                newName: "I_object_eemp");

            migrationBuilder.RenameTable(
                name: "I_Factory_eemp",
                schema: "isdata",
                newName: "I_Factory_eemp");

            migrationBuilder.RenameTable(
                name: "I_Factory_Division",
                schema: "isdata",
                newName: "I_Factory_Division");

            migrationBuilder.RenameTable(
                name: "I_division_object",
                schema: "isdata",
                newName: "I_division_object");

            migrationBuilder.RenameTable(
                name: "I_Division_eemp",
                schema: "isdata",
                newName: "I_Division_eemp");

            migrationBuilder.RenameTable(
                name: "H_object",
                schema: "isdata",
                newName: "H_object");

            migrationBuilder.RenameTable(
                name: "H_Factory",
                schema: "isdata",
                newName: "H_Factory");

            migrationBuilder.RenameTable(
                name: "H_eemp",
                schema: "isdata",
                newName: "H_eemp");

            migrationBuilder.RenameTable(
                name: "H_Division",
                schema: "isdata",
                newName: "H_Division");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b6f390d9-7e5d-4c80-8349-e8e4abf41860", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2288), "91ad6020-2ed7-4a63-af8a-02cdd0ca672c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ca9be208-eb50-4eb3-a34a-253b06b078bb", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2324), "9e99fab9-4096-436f-938c-05fd449f7ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "96a3f9f3-8f1e-4ee0-a103-c290e0c479b5", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2343), "322e530c-17f4-4e77-83a0-cbd0d21490ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6b2f6189-5fe5-4d7c-98d3-8f3cace96a6e", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2350), "efe27a4b-8544-4040-b80a-eb6718d1c464" });
        }
    }
}
