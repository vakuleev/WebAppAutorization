using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ResultsLimeMills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResultsLimeMills",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTrial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTrial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DateLimeOnManufakt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sito200 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sito80 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActiveLime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Entalpya = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SandProc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LimeMn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SandMn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LimeMnK = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SandMnK = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultsLimeMills", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11589b4c-67e2-4988-b68c-86e378ecc3cd", "4a1ff3b6-30c7-447f-9328-d4d3c14acc22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7a50cf6-61ba-4fcf-8e82-d5ee41a33192", "2724183b-88d7-4b62-9e56-5857c10a165b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16616fc3-7b7c-49c7-b690-28e1306c917a", "c28bbb1a-bbfa-4007-ab33-f668ac8d775b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d34dad2-03f4-49b9-ae15-dec4b2bea95f", "c720fcee-54c8-4828-8fff-88dde2315891" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultsLimeMills",
                schema: "datalab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c70010ce-c52c-4a93-9c5b-df5cb1cdec07", "168981d2-a98e-4aee-9c85-f45289e8acf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6608bef1-a578-47d0-9965-ea787288cbb3", "2ecbef04-24c5-4554-9b7d-f36b6a6bb654" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3927f70f-b8e9-446c-ab65-3612b02ec0e2", "acccadf5-dd65-415f-b3f0-34fa56e3c18f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d226ac0b-9f03-4bc6-937f-75b0f56b003c", "a863a6b9-5f5d-4883-91a0-e9ddf32a0f40" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
