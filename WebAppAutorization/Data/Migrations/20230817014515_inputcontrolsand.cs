using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
#pragma warning disable CS8981 // Имя типа содержит только строчные символы ASCII. Такие имена могут резервироваться для языка.
    public partial class inputcontrolsand : Migration
#pragma warning restore CS8981 // Имя типа содержит только строчные символы ASCII. Такие имена могут резервироваться для языка.
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48ed7e1a-c794-4ca9-b627-33742473c252", "0fecba15-2e78-4579-b4e0-6f083f51c15e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ff2e62f-d970-419a-be5d-aea3ee62e326", "aea258ca-54bc-427a-b884-99c37129ba8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cdf9c91-e554-483b-ba83-688fd93c341c", "96b372eb-10b1-419d-a0cc-e48835e71a19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caf2769f-0245-4902-9b40-f6acdcc23f46", "f9d70f70-e6cf-44af-a6de-c0a93c28b34a" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
