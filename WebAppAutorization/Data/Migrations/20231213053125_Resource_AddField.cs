using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class Resource_AddField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResName",
                schema: "data",
                table: "Sheetfs",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResName",
                schema: "data",
                table: "Orders",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d25d14b3-c9c0-4237-81d1-69330835d49b", new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(706), "6de7ba87-1c27-4cfa-9cd2-b0015a9b056e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b5faf03c-d809-4d2b-93a7-51566ea01716", new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(771), new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(771), "c09c6f46-e25d-4056-8f5e-901f5bca9d09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "fa343c92-77f5-4223-9525-5eaf128322f8", new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(790), new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(789), "e8a42639-0d81-4832-8b74-6d3f91f46b9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ef973467-50f8-4b6c-aded-c789adc597d8", new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(798), new DateTime(2023, 12, 13, 12, 31, 17, 947, DateTimeKind.Local).AddTicks(797), "be1d791f-69f2-49a9-99a8-d08bad63e354" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ResName",
                value: null);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ResName",
                value: null);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ResName",
                value: null);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ResName",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResName",
                schema: "data",
                table: "Sheetfs");

            migrationBuilder.DropColumn(
                name: "ResName",
                schema: "data",
                table: "Orders");

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
        }
    }
}
