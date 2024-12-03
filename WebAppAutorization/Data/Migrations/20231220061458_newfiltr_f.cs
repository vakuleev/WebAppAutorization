using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfiltr_f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ViewAllRes",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "d561b1ee-3056-40bd-a56b-fadd49e9c8f4", new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(391), new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(370), "f2969f54-a0cb-4380-95e4-348762d7717e", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "c4f7b27f-9362-4141-bf6b-b27d16cd2f5c", new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(454), new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(453), "107e35c9-831a-4f8a-8907-087e5959eea0", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "1f8d68e4-217e-4a99-b906-1682019d791f", new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(476), "8409ef9e-d9f3-4171-bc53-ef4e1a016e64", false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "474a12eb-e167-4d02-bb9d-24246d0e6087", new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 12, 20, 13, 14, 54, 35, DateTimeKind.Local).AddTicks(484), "56309667-d699-4dd0-8f14-52c06f7f21a5", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ViewAllRes",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "c353cf0f-1b44-40e3-aeff-5386c8ddbbb1", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(1728), "8a6a3dd6-b98c-490c-a782-e8e24460ada2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b6a64dc4-f19b-42bd-ba60-4152bdd75cba", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2014), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2012), "e038b75a-3cd7-40e0-ba8a-2bfc33c0f4f8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b8d652b0-98a5-4241-b4b1-93f38f87ae22", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2034), "225238df-aab2-44a4-9312-ac3038d84187", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp", "ViewAllRes" },
                values: new object[] { "b71b10f9-77b5-4b9f-b6a3-ed7218f4a54d", new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 12, 20, 12, 36, 42, 172, DateTimeKind.Local).AddTicks(2042), "963fd81e-9a0f-4c15-95d7-701be2008460", null });
        }
    }
}
