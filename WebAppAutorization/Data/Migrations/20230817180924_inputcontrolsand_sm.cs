using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class inputcontrolsand_sm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SizeModulus",
                schema: "datalab",
                table: "InputControlSands",
                type: "decimal(18,2)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeModulus",
                schema: "datalab",
                table: "InputControlSands");

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
        }
    }
}
