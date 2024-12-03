using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class Order_Fielr_OverLimit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OverLimit",
                schema: "data",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "76fcb8a2-4dfb-4a26-b639-75849b27e93f", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4937), "68884cb4-cce6-452d-9c8d-5ba4d9d23faf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8c755d60-1092-41d5-90ae-33a295698dff", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4979), "eb8678c3-e118-408c-a677-b7231b68665e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1f3174cc-9c64-4646-9a10-ffee0a914a98", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(4997), "bfff3639-d58a-4584-8c73-328e7b22a26d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "86387121-4db4-42b3-bd23-6e8d806aad5c", new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 12, 14, 11, 22, 13, 294, DateTimeKind.Local).AddTicks(5005), "9b4866fd-efcb-411b-8a2e-5a52b7224127" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "OverLimit",
                value: false);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                column: "OverLimit",
                value: false);

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverLimit",
                schema: "data",
                table: "Orders");

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
    }
}
