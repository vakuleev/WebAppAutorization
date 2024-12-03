using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ResultsPortlandCements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Agent",
                schema: "datalab",
                table: "ResultsLimeMills",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ResultsPortlandCements",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTrial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sito90 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CoeffWaterSepar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpecificSurface = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NormDensityCementPaste = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BeginCementSet = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    EndCementSet = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultsPortlandCements", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db868fb6-564c-4dda-b715-352464c4c4aa", "95a9b56b-61aa-47ee-9eb3-8ebc724222fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df929d45-6644-4f17-b9e4-21bb5056cb23", "95bb40b6-6743-4f0b-800f-1153652c53d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0491006a-2f62-4388-b969-f4dfba44d94f", "1ae068b6-2a1a-486e-87bc-abe6f4b66f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "410a532a-bf0d-4594-9de8-8713a47bf8a5", "ff2ae30d-99b4-4b0c-a2e6-9283f46d1be9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultsPortlandCements",
                schema: "datalab");

            migrationBuilder.AlterColumn<string>(
                name: "Agent",
                schema: "datalab",
                table: "ResultsLimeMills",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0628626e-fa30-492d-bfbb-ed1f899f2df3", "778a2c9c-eb5b-4ef4-a470-3d3858642065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d982e366-2525-49b1-b593-61579a8384c0", "efc8068b-d783-4b6f-80dc-b9d23fc12084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91236e50-01d3-4c78-9c35-dc726c64e339", "1bccd519-9d40-42ae-af15-d88530195546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef7cc654-2094-4524-b5b2-9a72da723390", "31264de0-005d-4c80-b489-9dbcd8cd359d" });
        }
    }
}
