using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesLAB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IzvestFromSiloss",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTrial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTrial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Enthalpiy = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Activity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzvestFromSiloss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SandSludgePools",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTrial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTrial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NumPool = table.Column<int>(type: "int", nullable: false),
                    Density = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ResidueOnSieve = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GypsumContentSandSlurry = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SandSludgePools", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08b3f102-414f-4dfe-9f73-c7bd46dbfd61", "e8b98840-da29-4907-a666-c9bce92b0ded" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "326f9636-b3a3-4e71-a8ef-9c0c7077122f", "d3479b10-a3b7-4f15-b2fa-12c6be2e497f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1564316f-9b68-4d7e-84ad-f1255a2775c9", "2c74b14e-a862-43f7-8299-c56e6b488c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "681ec04f-5fd6-4021-bc10-b6762f379cb9", "9331b493-1dcd-4bc6-85cf-57677ee79121" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IzvestFromSiloss",
                schema: "datalab");

            migrationBuilder.DropTable(
                name: "SandSludgePools",
                schema: "datalab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c8f23e5-77e1-4bb7-8533-5a61185a004c", "090db1eb-23ac-439b-9cef-0e7bb6c56fa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9faa99c-b2c3-4edf-97ed-df18b4b4966e", "40475a6c-2e4b-4b30-ab23-21df823c4e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84fbdc78-150e-44a7-b1ea-1a4d6cf765c8", "fa819a0d-2e64-49ed-a2ba-642b19691c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22eacd86-f0d7-4753-937e-e3b1624693eb", "27d3e8b7-b217-4b08-9506-cdd796e68ab6" });
        }
    }
}
