using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class dttm_NOT_NULL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "db534e36-b54e-457b-9d0c-5015e261c870", new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3560), "e388bb37-4e3c-483e-bea3-3396c7086197" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7aa4ce6c-0eb9-47b5-be11-0a6b8153f0c6", new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3597), "66ac7e72-ad73-4ec1-a758-f38185edebb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "bcf324ff-048b-4be7-ab53-7cf280763031", new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3616), "ded4dfa6-e955-448e-b1e7-ee6288b0cc92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b53bdf13-18f8-4c93-9f77-38df45a66ef2", new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 10, 27, 13, 7, 3, 0, DateTimeKind.Local).AddTicks(3625), "dd8eb2c7-1cdb-4729-aad1-fcbb3a540943" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
