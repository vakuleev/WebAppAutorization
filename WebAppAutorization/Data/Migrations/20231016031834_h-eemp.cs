using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class heemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "adress",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Factory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Division",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f81b9434-5dc4-41a3-9c43-dcb7b9a09df0", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7939), "00d698b7-e918-425a-8d22-647cbfea6e51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "5dab5eef-555e-48d8-be0a-7e2b948bffd2", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7978), "7c0b5a68-965c-4715-85b0-fb0f25c70edf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d2894af6-591e-406a-bd5d-2b515bf87201", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7998), "cd1a1dd7-c538-431a-a9d5-8cad6a4cfabd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f5e3aa9d-f61e-4128-bf52-6fab3f1ad49f", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(8006), "44acf38e-68ad-41ec-bc12-6bca68d30200" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "adress",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Factory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Division",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7942ca50-d729-4042-8429-b5e7c3d81392", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1748), "0d0286cb-a846-4bef-9de2-4031e35118f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "47cf473e-b4cd-4c15-ab03-15580a5265f4", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1971), "45972eee-9cd3-43f6-9fee-6b86c8114762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6b77319e-e7d5-4c6a-952f-21459129af8e", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2005), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2004), "fc73ba48-cbc4-477a-9c28-1207e39c90a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e555027e-48fc-464d-a61a-938d7eaa779c", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2012), "3ce2d583-1442-4c1b-8fe4-093f5e4c5dc3" });

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
    }
}
