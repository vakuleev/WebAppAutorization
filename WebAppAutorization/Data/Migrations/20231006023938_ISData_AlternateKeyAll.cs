using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_AlternateKeyAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "H_object",
                schema: "isdata",
                newName: "H_object");

            migrationBuilder.RenameTable(
                name: "H_eemp",
                schema: "isdata",
                newName: "H_eemp");

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                table: "H_object",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name_object",
                table: "H_object",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                table: "H_eemp",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name_point",
                table: "H_eemp",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_H_object_prefix_name_object",
                table: "H_object",
                columns: new[] { "prefix", "name_object" });

            migrationBuilder.AddUniqueConstraint(
                name: "AK_H_eemp_prefix_name_point",
                table: "H_eemp",
                columns: new[] { "prefix", "name_point" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f7e31247-77a2-4a75-8681-032d7a49dc72", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8148), "c39154e6-855d-4b3d-bd98-98bb5a349a4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ff0549bd-8878-4737-8d47-4a790a3eb9e7", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8183), "3374e3ce-d331-43fe-b8cf-28f20ff70322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b5684c8a-4ccd-40fe-b98c-c605ad921ed6", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8199), "3b4a6e06-ef8e-4dac-97aa-7a5ada945512" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4685a618-fca5-4857-91f6-9a6a6cbfd6fc", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8207), "a4bd2a71-faab-4cfa-957f-a66d7b7fbc38" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_H_object_prefix_name_object",
                table: "H_object");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_H_eemp_prefix_name_point",
                table: "H_eemp");

            migrationBuilder.RenameTable(
                name: "H_object",
                newName: "H_object",
                newSchema: "isdata");

            migrationBuilder.RenameTable(
                name: "H_eemp",
                newName: "H_eemp",
                newSchema: "isdata");

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_object",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "name_object",
                schema: "isdata",
                table: "H_object",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "prefix",
                schema: "isdata",
                table: "H_eemp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "name_point",
                schema: "isdata",
                table: "H_eemp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
        }
    }
}
