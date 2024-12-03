using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class InputControlIzvests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InputControlIzvests",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateReceipt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UnquencheGrains = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Activity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WetBulkDensity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExtinguishingTime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExtinguishingTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UniformityVolumeChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputControlIzvests", x => x.Id);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputControlIzvests",
                schema: "datalab");

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
    }
}
