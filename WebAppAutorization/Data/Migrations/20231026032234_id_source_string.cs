using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class id_source_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_source",
                schema: "isdata",
                table: "H_object",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "id_source",
                schema: "isdata",
                table: "H_eemp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "id_source",
                schema: "isdata",
                table: "H_Division",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_object",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_eemp",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Division",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4a9a8f37-fb5a-404a-b9b5-670564d09cce", new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5839), "131fc019-d0de-45b1-b7a2-8fbcdd36279e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "791fc653-00a9-4e88-b1f6-86eca4458099", new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5879), "f51b37a1-fe92-4948-a324-04bae8ad5973" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f0032c1e-782a-44f8-87b9-05d35e30036a", new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5897), "88c468df-66d3-476c-b7f8-37cca30f9a73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "9934ee66-948d-486a-9c35-b9b602004af6", new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 10, 26, 9, 54, 5, 244, DateTimeKind.Local).AddTicks(5905), "ad0b6101-a9cf-4ffb-91c1-682e34353573" });
        }
    }
}
