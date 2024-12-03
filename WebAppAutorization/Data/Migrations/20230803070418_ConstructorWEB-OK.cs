using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConstructorWEBOK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "datalab");

            migrationBuilder.CreateTable(
                name: "SandSludgeMills",
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
                    DensityReturnSludge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SandSludgeMills", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f8046af-d89b-4a68-8b25-6a61c9dcf114", "3dfb6e6c-0e0f-4ec4-857e-abd39fadabe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6782906-a340-4047-a32c-d90bcfb464c2", "85c76035-c495-4fe6-9250-894ac5a78b9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c2295cf-8f15-4c5b-9fd3-f025da61b9eb", "7406a4c2-6194-4c35-ac97-6d641e17bf03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bfe72e4-e860-4eb5-84f5-afa9bfdd07e8", "edf0f7e1-255e-4beb-b067-e1ffd98456fe" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SandSludgeMills",
                schema: "datalab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ff935d5-6a43-4f33-8652-ca2a271e6a22", "85a7e4bc-e068-4e4e-8753-7e3c99530175" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b12af566-f638-4c72-9cca-13de0eab0ef4", "62687778-a03a-4ff0-9666-8b099c9f3b7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76045a54-43d4-4c0d-9e2b-721d7bd462cc", "49c87df8-abc6-4a7d-98a7-824896d6b832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4644835c-1756-4ce5-b9a2-6dd92777f30c", "cc8a4f83-111e-4440-856a-6094ac2153ab" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
