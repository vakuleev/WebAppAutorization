using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_AlternateKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "I_object_eemp",
                schema: "isdata",
                newName: "I_object_eemp");

            migrationBuilder.RenameTable(
                name: "I_Factory_Division",
                schema: "isdata",
                newName: "I_Factory_Division");

            migrationBuilder.RenameTable(
                name: "I_division_object",
                schema: "isdata",
                newName: "I_division_object");

            migrationBuilder.RenameTable(
                name: "H_Factory",
                schema: "isdata",
                newName: "H_Factory");

            migrationBuilder.RenameTable(
                name: "H_Division",
                schema: "isdata",
                newName: "H_Division");

            migrationBuilder.AlterColumn<string>(
                name: "name_factory",
                table: "H_Factory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                table: "H_Division",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name_division",
                table: "H_Division",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_H_Factory_name_factory",
                table: "H_Factory",
                column: "name_factory");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_H_Division_prefix_name_division",
                table: "H_Division",
                columns: new[] { "prefix", "name_division" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d7559555-dfe9-4589-97e6-89029daaeca9", new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3556), "291365b2-84bd-4c34-8c99-c0a85c311347" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "aa816724-340a-4ffb-8c0a-14534adaf7d8", new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3596), "8f8ae97d-1e97-4dca-a846-f14fc2d0d47b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d3781aff-9f9a-4f3a-84f7-6a3160cb7013", new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3615), "2a9b91a8-fb3d-4e7a-9328-650d212d6635" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "128f0eba-afc6-476a-98c9-06572ddaa9c1", new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 10, 6, 8, 51, 9, 283, DateTimeKind.Local).AddTicks(3623), "0781709c-21fe-486f-a584-bf7e6883ded1" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_H_Factory_name_factory",
                table: "H_Factory");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_H_Division_prefix_name_division",
                table: "H_Division");

            migrationBuilder.RenameTable(
                name: "I_object_eemp",
                newName: "I_object_eemp",
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
                name: "H_Factory",
                newName: "H_Factory",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_Division",
                newName: "H_Division",
                newSchema: "isdata");

            migrationBuilder.AlterColumn<string>(
                name: "name_factory",
                schema: "isdata",
                table: "H_Factory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_Division",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "name_division",
                schema: "isdata",
                table: "H_Division",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
