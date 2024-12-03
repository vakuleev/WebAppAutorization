using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesField2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateTimeTrial",
                schema: "datalab",
                table: "SandSludgePools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateTimeTrial",
                schema: "datalab",
                table: "SandSludgeMills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "724519f9-2b46-4f90-ab7c-e6646c47e207", "f5c3b412-d6e3-4912-b21f-1aea50f76ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38d3978f-35c7-4782-87ce-b7e0b4d4892c", "f1e802a9-f47f-4cf1-aa6f-1296505be1d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84549d31-09cf-4dac-ad79-511593d7bc6f", "c40414be-b2ec-4719-9336-b4885491cda5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae6efde6-8d8c-44d0-b2a6-fe53b0fd80fa", "5d360e01-fb25-4fbe-89c3-c1d0997ac3d3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeTrial",
                schema: "datalab",
                table: "SandSludgePools");

            migrationBuilder.DropColumn(
                name: "DateTimeTrial",
                schema: "datalab",
                table: "SandSludgeMills");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae1855d3-6abf-4187-a672-f9644db1216e", "71dcb144-803b-44a2-a3dd-0a3aee8efb1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42ce6fb5-8eb7-4413-b71d-766db0ad27dc", "6839e2b7-5d88-43fe-8f1d-06528f9a9854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16dfd862-3096-49c1-b072-82f30a202765", "5a846733-40dd-44d0-a594-25bdc670ee1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46878ab3-6c1f-4cb5-8fc1-584b39de699e", "0bfca5b1-7494-45e6-9286-28420f5e1cf6" });
        }
    }
}
