using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
#pragma warning disable CS8981 // Имя типа содержит только строчные символы ASCII. Такие имена могут резервироваться для языка.
    public partial class icontrolsand : Migration
#pragma warning restore CS8981 // Имя типа содержит только строчные символы ASCII. Такие имена могут резервироваться для языка.
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IControlSands",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateReceipt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalSandReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WaterSand = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WetBulkDensity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ClaySubstances = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IControlSands", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60146c90-e1c3-4a4e-8ce5-b19b16d6a10d", "fd4604a4-3535-4700-9f9c-d3cba0817dbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66e50feb-6910-475b-b4ed-0c6f62b4ab21", "799d6bfc-a66d-434b-9fcb-a25cf255dec1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71e5b235-9455-4a20-9f55-18afb880beb1", "0f651cad-885d-4246-97b3-46cb0c69e14f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e925c5ec-4d8a-480a-a5fc-e86613b1bf72", "c50cc8f6-d0e8-4ff5-a75b-ed2948908228" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IControlSands",
                schema: "datalab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "356211dd-5fd2-40a6-9504-09c58d7967c2", "ae02c12d-50fe-496b-8759-f4bc2502c28f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00c32395-f5f0-429e-8b68-a23a64a1a370", "59c58a4c-b0e1-4e42-a842-9bf07dc860b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1b9e65a-8c76-4f7b-90c4-82b85311ed02", "9413356d-4de1-4370-badc-df98f6921853" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "834c4812-196c-4b3e-ac96-064a0fd531a3", "95929cb9-45fc-4276-8fb7-d943f5ae498f" });
        }
    }
}
