using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class factorysource_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_source",
                schema: "isdata",
                table: "H_Factory",
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

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id_source",
                schema: "isdata",
                table: "H_Factory",
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
                values: new object[] { "8e9a51a0-65da-412e-86ea-e784315463c3", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6359), "8f83779a-d75d-421c-a98e-f3119f909855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6afc8f02-3980-4271-aa92-1029bed1aa98", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6399), "64f21198-2e4e-4128-889d-e689d1616b8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "97dc48ec-ab47-46bd-a277-c2034053240f", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6417), "e864bdf0-2027-4fd6-ae41-56eadebe14d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7f339914-82cc-4ce6-9475-1eb5afab1f5c", new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 10, 25, 13, 18, 57, 627, DateTimeKind.Local).AddTicks(6425), "6691d174-5214-4006-8167-ab3e4771ca0b" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
