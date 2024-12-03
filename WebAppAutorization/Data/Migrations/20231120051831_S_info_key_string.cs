using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class S_info_key_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_object_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_eemp_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "valid_until_dttm",
                schema: "isdata",
                table: "S_eemp_cc",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "valid_from_dttm",
                schema: "isdata",
                table: "S_eemp_cc",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Division_info",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "99edff07-3ef5-4555-992a-5830c7640f41", new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4031), new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4012), "f4ed8c52-f5b4-45e3-ab5e-4d4a3899dd20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b7de085f-fe8c-414b-8dfc-63f40c247950", new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4053), new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4052), "0ca87b61-0086-454e-b38d-6af46c6d8dd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "bc845664-760d-4f48-b104-a2e10629ad26", new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4079), new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4079), "e772258e-e37d-4e67-a436-4dea24b7ee91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "76f3dd37-8e00-4d70-8ceb-386d3e3580ba", new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4148), new DateTime(2023, 11, 20, 12, 18, 23, 308, DateTimeKind.Local).AddTicks(4147), "2b2d7e89-5d4d-4810-a95f-8332ecc38a88" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_object_info",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_eemp_info",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_until_dttm",
                schema: "isdata",
                table: "S_eemp_cc",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "valid_from_dttm",
                schema: "isdata",
                table: "S_eemp_cc",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Division_info",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "c44473db-c951-47cf-b7fd-16915c03febc", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6177), "7cefd53f-a5dd-43d4-8558-42212ff3f217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "3f05a2d3-ade4-47ed-8c93-af7e8a325acb", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6210), "6962875e-9f2e-4b9b-9bf8-cd596a347e32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "41ada749-3bce-4ac2-ba36-d69f47acbf0f", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6231), "ffc5e120-ecba-495a-83f3-228abe3c6d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "87a24c7a-2c16-4f9c-9b08-2aff12ebe71e", new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 16, 10, 54, 0, 779, DateTimeKind.Local).AddTicks(6239), "f2febdfb-832a-4493-917b-3d436d9f218a" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
