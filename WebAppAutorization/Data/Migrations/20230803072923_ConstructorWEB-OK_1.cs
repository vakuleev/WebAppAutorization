using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConstructorWEBOK_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
