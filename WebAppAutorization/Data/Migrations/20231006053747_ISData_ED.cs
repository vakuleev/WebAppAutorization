using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_ED : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "I_Division_eemp",
                columns: table => new
                {
                    id_division = table.Column<int>(type: "int", nullable: false),
                    id_eemp = table.Column<int>(type: "int", nullable: false),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Division_eemp", x => new { x.id_division, x.id_eemp });
                });

            migrationBuilder.CreateTable(
                name: "S_eemp_info",
                schema: "isdata",
                columns: table => new
                {
                    id_eemp = table.Column<int>(type: "int", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    factory_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_next_verif = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_eemp_info", x => x.id_eemp);
                });

            migrationBuilder.CreateTable(
                name: "S_Factory_info",
                schema: "isdata",
                columns: table => new
                {
                    id_factory = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_Factory_info", x => x.id_factory);
                });

            migrationBuilder.CreateTable(
                name: "S_object_info",
                schema: "isdata",
                columns: table => new
                {
                    id_object = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_object_info", x => x.id_object);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b6f390d9-7e5d-4c80-8349-e8e4abf41860", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2288), "91ad6020-2ed7-4a63-af8a-02cdd0ca672c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ca9be208-eb50-4eb3-a34a-253b06b078bb", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2324), "9e99fab9-4096-436f-938c-05fd449f7ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "96a3f9f3-8f1e-4ee0-a103-c290e0c479b5", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2343), "322e530c-17f4-4e77-83a0-cbd0d21490ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6b2f6189-5fe5-4d7c-98d3-8f3cace96a6e", new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 10, 6, 12, 37, 39, 138, DateTimeKind.Local).AddTicks(2350), "efe27a4b-8544-4040-b80a-eb6718d1c464" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "I_Division_eemp");

            migrationBuilder.DropTable(
                name: "S_eemp_info",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "S_Factory_info",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "S_object_info",
                schema: "isdata");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f7e31247-77a2-4a75-8681-032d7a49dc72", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8166), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8148), "c39154e6-855d-4b3d-bd98-98bb5a349a4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "ff0549bd-8878-4737-8d47-4a790a3eb9e7", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8183), "3374e3ce-d331-43fe-b8cf-28f20ff70322" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "b5684c8a-4ccd-40fe-b98c-c605ad921ed6", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8199), "3b4a6e06-ef8e-4dac-97aa-7a5ada945512" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4685a618-fca5-4857-91f6-9a6a6cbfd6fc", new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 10, 6, 9, 39, 30, 548, DateTimeKind.Local).AddTicks(8207), "a4bd2a71-faab-4cfa-957f-a66d7b7fbc38" });
        }
    }
}
