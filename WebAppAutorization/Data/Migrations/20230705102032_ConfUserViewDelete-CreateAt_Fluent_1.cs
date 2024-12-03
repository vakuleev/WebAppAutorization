using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfUserViewDeleteCreateAt_Fluent_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                schema: "data",
                table: "Sheetfs",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec7371ec-44c0-4a07-a808-864b86dcbc5b", "ab0f6636-55c6-4cc9-bb03-22fb226e7e7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a220089b-ba9e-4c85-a5f7-467d6c2748e1", "16565ce1-6f0d-4d43-bd0e-2039e876bae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0b21eed-34e5-45b9-8a2c-a06ff4bff476", "a11d14c3-8241-479e-9d0d-8495c2d7400b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "628039c9-7809-4350-a0ff-be7dc2df13bd", "588ad009-0a5e-4a50-a04a-4a7873e8d264" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                schema: "data",
                table: "Sheetfs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a228d8bf-d383-49cd-9849-1a3edc873ff7", "e70d71f3-180f-4f4f-8a0f-f6609d4551e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bab9c7ae-f6f6-468d-b02b-f438cb1879a0", "4fc220dc-0eb3-4d58-8a42-f167ade7f45d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "281f115d-6975-4176-aac7-86b013d7350a", "9fdde179-68fb-427f-bf1c-1cd0643a3f7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f31a6bee-e60b-45f7-9f17-db023d59e84f", "ebae8c41-6220-45c2-b4df-d1d044e6d6f7" });
        }
    }
}
