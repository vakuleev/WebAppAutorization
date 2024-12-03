using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class dttm_NOT_NULL_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "23640765-98e4-4450-991b-fdf677010389", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8532), "ec8eef75-b279-41af-a50f-9db9cddac520" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7631b0f8-57c1-4f0f-8f24-2fc1ca1fd8d3", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8573), "bcea2161-b2d6-4cd9-8cc9-f79f7830c203" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "8e2a290a-ec66-47de-9691-921d04639f15", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8623), "226037b5-2bd4-4ed6-8748-4ff51d6857c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "84937516-7d65-4e58-b83d-7280c5af5185", new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 10, 27, 13, 35, 3, 643, DateTimeKind.Local).AddTicks(8633), "44d0591f-b170-4d14-83b8-1227c7295f64" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
