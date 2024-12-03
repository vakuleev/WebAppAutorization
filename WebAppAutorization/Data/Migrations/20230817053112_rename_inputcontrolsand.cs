using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class rename_inputcontrolsand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IControlSands",
                schema: "datalab");

            migrationBuilder.CreateTable(
                name: "InputControlSands",
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
                    table.PrimaryKey("PK_InputControlSands", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "205aa085-f7b2-4fdd-9bf1-612b7f15571e", "f4dc70b2-2a68-4f63-8de0-aff995519f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "565d4fe9-0630-4114-a4b4-2a18410dd029", "a86fd563-8159-48f6-ad57-0eff4d4a93bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "226b3b13-3004-45c1-8f32-b4f78216dfeb", "67967369-8b56-4021-afff-48ef17c6fb06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a9d312f-166c-42ef-84d4-a06bee763b0c", "310f2460-ab99-441a-a278-92a6e95e1e58" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputControlSands",
                schema: "datalab");

            migrationBuilder.CreateTable(
                name: "IControlSands",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaySubstances = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReceipt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalSandReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WaterSand = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WetBulkDensity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
    }
}
