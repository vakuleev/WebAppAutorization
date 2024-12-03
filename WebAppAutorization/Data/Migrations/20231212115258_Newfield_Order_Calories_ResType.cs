using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class Newfield_Order_Calories_ResType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OverLimit",
                schema: "data",
                table: "Sheetfs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ResType",
                schema: "data",
                table: "Sheetfs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "SumNalog",
                schema: "data",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductStoim",
                schema: "data",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                schema: "data",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResType",
                schema: "data",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "769c5534-3409-48af-91fd-c4ceb07244f9", new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3050), "b3312ffa-79d6-4040-a30c-765e43c59cb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "2d7f16ed-ddec-4f26-a8b5-d3c76174af76", new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3228), "194e45e3-5550-4b11-a281-1ec4a787431d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4ff483d3-57cd-4c16-a825-93aad47fd854", new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3247), "c12745cd-25b7-4137-b6a9-bf159050b1ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "fbe62bc0-9812-4ebe-aadf-6eaaea8a3ca9", new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 12, 12, 18, 52, 50, 278, DateTimeKind.Local).AddTicks(3255), "5ecff89e-9719-464a-b9af-c5b9ce1aaba4" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Calories", "ProductStoim", "ResType", "SumNalog", "SumProductNalog" },
                values: new object[] { null, 225721.87m, 3, 45144.37m, 270866.24m });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Calories", "ProductStoim", "ResType", "SumNalog", "SumProductNalog" },
                values: new object[] { null, 1059593.03m, 3, 211918.6m, 1271511.63m });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateAct", "OverLimit", "ResType" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DateAct", "OverLimit", "ResType" },
                values: new object[] { new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverLimit",
                schema: "data",
                table: "Sheetfs");

            migrationBuilder.DropColumn(
                name: "ResType",
                schema: "data",
                table: "Sheetfs");

            migrationBuilder.DropColumn(
                name: "Calories",
                schema: "data",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ResType",
                schema: "data",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "SumNalog",
                schema: "data",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ProductStoim",
                schema: "data",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ProductStoim", "SumNalog", "SumProductNalog" },
                values: new object[] { 225721.87092m, 45144.374184m, 270866.245104m });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "ProductStoim", "SumNalog", "SumProductNalog" },
                values: new object[] { 1059593.03998731m, 211918.607997462m, 1271511.647984772m });

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
    }
}
