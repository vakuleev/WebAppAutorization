using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class Satelit_remove_key_description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_object_info",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_eemp_info",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Division_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info",
                column: "load_dttm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info",
                column: "load_dttm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info",
                column: "load_dttm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info",
                column: "load_dttm");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b22cd832-96ba-4b27-96ee-a7adf8448eaa", new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1024), new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1007), "7e49759b-b43e-4122-93f7-cf903edf9476" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6d1d0e90-cb12-4083-8175-b37b83444fb7", new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1043), "e3764b77-d371-4162-9d0b-25193a7d4e08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "bf52402d-1199-4e95-be7c-d29408907819", new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1062), new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1061), "2693e825-0c0e-4cf4-b268-95419341ebf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "30ec53aa-eb57-4358-b03d-035b451dd968", new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1070), new DateTime(2023, 10, 26, 15, 9, 49, 761, DateTimeKind.Local).AddTicks(1069), "72dfe15c-80fb-4e0c-80e5-48f54d21f572" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_object_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_eemp_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Division_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8c970525-9c29-4e78-b109-25a4d4234947", new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6565), "367df9d5-0bac-4598-9c2a-c1e9e436fdf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "df6f74d8-19f6-4461-8018-f43208bab627", new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6600), "d1753bea-9a08-45f6-96b4-fcc67ac8bf5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4679725d-e1f2-451d-bc73-3b1ffc4a8c78", new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6625), "161ed517-cb31-4159-9424-6960da84c3f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "993b826c-579e-4324-8287-a050e4382661", new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 10, 26, 10, 22, 28, 966, DateTimeKind.Local).AddTicks(6632), "6a9de117-68b9-4f28-baff-547483fd4f07" });
        }
    }
}
