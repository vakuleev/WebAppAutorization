using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class Resource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ab811891-f476-467e-97a8-e2c8da2cfdbd", new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9332), new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9313), "c2addd00-af88-4142-b56f-af043fe8eb11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6ef8b93a-fe0d-4e0f-81aa-172a539b5caf", new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9353), "6bef929d-7bf0-41ae-abde-8ca7957adc6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "380e1e63-b84c-4f47-80b0-74d5a6ebb3d6", new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9372), "e4bb7b1a-c4df-4ab0-b63e-8443ed9cc839" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f3e89cfc-d783-4ec1-b2c6-a36a33b55e5e", new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 12, 13, 11, 20, 58, 15, DateTimeKind.Local).AddTicks(9381), "b436dd4f-25b7-454a-bfaf-8db7a3178160" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources",
                schema: "data");

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
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
