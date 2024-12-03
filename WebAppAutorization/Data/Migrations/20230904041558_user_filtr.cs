using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class user_filtr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeTrial",
                schema: "datalab",
                table: "SandSludgeMills",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTrial",
                schema: "datalab",
                table: "SandSludgeMills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFiltrEnd",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateFiltrStart",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e94d99b7-cb3b-4101-af62-26544dc288b8", new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4669), "67b1c5b0-f94d-48fc-aa53-4983993290f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "eb5705a6-420b-4bf5-8406-0e1f385ab368", new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4747), "accfaa96-3aa5-4841-a625-36010bb5ab92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "305daf8d-45a3-4cb3-8872-673927ce0bbd", new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4766), new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4766), "1d84d524-c61e-41ef-b4f6-1bf3761d0236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ed6b664f-7987-416d-ac85-07b0880b5ada", new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 9, 4, 11, 15, 49, 284, DateTimeKind.Local).AddTicks(4773), "5707f84c-edba-4b73-b1a2-766de762f4c8" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFiltrEnd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateFiltrStart",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "TimeTrial",
                schema: "datalab",
                table: "SandSludgeMills",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTrial",
                schema: "datalab",
                table: "SandSludgeMills",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b6bb9d3-3ef4-48c7-8c5d-c1badb3585e3", "e01db311-4a80-4fff-b671-2028174a9660" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e25a725-1763-470e-8f9a-63f3d4e6c05d", "52601bc1-8229-49c7-9849-b769dfcffeee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ee9243e-f4d3-48c3-a328-a880b53bb9c2", "3e3cdd8e-5803-45c9-910a-e77878109f2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "646b5ccf-ca68-489c-8bd3-81289b108887", "9d69d926-2ed5-4f95-87d8-d7bffa409d7e" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
