using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataFiltrs",
                schema: "datalab");

            migrationBuilder.EnsureSchema(
                name: "isdata");

            migrationBuilder.CreateTable(
                name: "H_Division",
                schema: "isdata",
                columns: table => new
                {
                    id_division = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_division = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_Division", x => x.id_division);
                });

            migrationBuilder.CreateTable(
                name: "H_eemp",
                schema: "isdata",
                columns: table => new
                {
                    id_eemp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_point = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: true),
                    id_parent = table.Column<int>(type: "int", nullable: true),
                    virtual_counter = table.Column<bool>(type: "bit", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_eemp", x => x.id_eemp);
                });

            migrationBuilder.CreateTable(
                name: "H_Factory",
                schema: "isdata",
                columns: table => new
                {
                    id_factory = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_factory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_Factory", x => x.id_factory);
                });

            migrationBuilder.CreateTable(
                name: "H_object",
                schema: "isdata",
                columns: table => new
                {
                    id_object = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_object = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_object", x => x.id_object);
                });

            migrationBuilder.CreateTable(
                name: "I_Factory_Division",
                schema: "isdata",
                columns: table => new
                {
                    id_factory = table.Column<int>(type: "int", nullable: false),
                    id_division = table.Column<int>(type: "int", nullable: false),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Factory_Division", x => new { x.id_factory, x.id_division });
                    table.ForeignKey(
                        name: "FK_I_Factory_Division_H_Division_id_division",
                        column: x => x.id_division,
                        principalSchema: "isdata",
                        principalTable: "H_Division",
                        principalColumn: "id_division",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_Factory_Division_H_Factory_id_factory",
                        column: x => x.id_factory,
                        principalSchema: "isdata",
                        principalTable: "H_Factory",
                        principalColumn: "id_factory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_Factory_eemp",
                columns: table => new
                {
                    id_eemp = table.Column<int>(type: "int", nullable: false),
                    id_factory = table.Column<int>(type: "int", nullable: false),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    h_eempid_eemp = table.Column<int>(type: "int", nullable: true),
                    h_factoryid_factory = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_Factory_eemp", x => new { x.id_factory, x.id_eemp });
                    table.ForeignKey(
                        name: "FK_I_Factory_eemp_H_Factory_h_factoryid_factory",
                        column: x => x.h_factoryid_factory,
                        principalSchema: "isdata",
                        principalTable: "H_Factory",
                        principalColumn: "id_factory");
                    table.ForeignKey(
                        name: "FK_I_Factory_eemp_H_eemp_h_eempid_eemp",
                        column: x => x.h_eempid_eemp,
                        principalSchema: "isdata",
                        principalTable: "H_eemp",
                        principalColumn: "id_eemp");
                });

            migrationBuilder.CreateTable(
                name: "I_division_object",
                schema: "isdata",
                columns: table => new
                {
                    id_division = table.Column<int>(type: "int", nullable: false),
                    id_object = table.Column<int>(type: "int", nullable: false),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_division_object", x => new { x.id_division, x.id_object });
                    table.ForeignKey(
                        name: "FK_I_division_object_H_Division_id_division",
                        column: x => x.id_division,
                        principalSchema: "isdata",
                        principalTable: "H_Division",
                        principalColumn: "id_division",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_division_object_H_object_id_object",
                        column: x => x.id_object,
                        principalSchema: "isdata",
                        principalTable: "H_object",
                        principalColumn: "id_object",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "I_object_eemp",
                schema: "isdata",
                columns: table => new
                {
                    id_object = table.Column<int>(type: "int", nullable: false),
                    id_eemp = table.Column<int>(type: "int", nullable: false),
                    load_dttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    H_Factorysid_factory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_object_eemp", x => new { x.id_object, x.id_eemp });
                    table.ForeignKey(
                        name: "FK_I_object_eemp_H_Factory_H_Factorysid_factory",
                        column: x => x.H_Factorysid_factory,
                        principalSchema: "isdata",
                        principalTable: "H_Factory",
                        principalColumn: "id_factory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_object_eemp_H_eemp_id_eemp",
                        column: x => x.id_eemp,
                        principalSchema: "isdata",
                        principalTable: "H_eemp",
                        principalColumn: "id_eemp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_I_object_eemp_H_object_id_object",
                        column: x => x.id_object,
                        principalSchema: "isdata",
                        principalTable: "H_object",
                        principalColumn: "id_object",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e9330509-19c9-4e4b-92dd-118a5b11d385", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5078), "d95765ec-6d46-4b90-904d-80be5b3f8f38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "117f2ab6-1276-439a-ae33-1ac6576a4b3a", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5114), "a4329277-87f1-499a-81b6-1e39ca05eb18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1c325acf-46ea-4824-8244-e810c4022d6b", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5134), "a7ad328a-198a-4563-b2bf-269e2ce2fb86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "af3c3d11-cde3-442d-9c61-cf95b58f27da", new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 9, 26, 4, 2, 17, 128, DateTimeKind.Local).AddTicks(5142), "42101876-c6e0-4f50-8526-6d1b528155ea" });

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateAct",
                value: new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "data",
                table: "Sheetfs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateAct",
                value: new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_I_division_object_id_object",
                schema: "isdata",
                table: "I_division_object",
                column: "id_object");

            migrationBuilder.CreateIndex(
                name: "IX_I_Factory_Division_id_division",
                schema: "isdata",
                table: "I_Factory_Division",
                column: "id_division");

            migrationBuilder.CreateIndex(
                name: "IX_I_Factory_eemp_h_eempid_eemp",
                table: "I_Factory_eemp",
                column: "h_eempid_eemp");

            migrationBuilder.CreateIndex(
                name: "IX_I_Factory_eemp_h_factoryid_factory",
                table: "I_Factory_eemp",
                column: "h_factoryid_factory");

            migrationBuilder.CreateIndex(
                name: "IX_I_object_eemp_H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp",
                column: "H_Factorysid_factory");

            migrationBuilder.CreateIndex(
                name: "IX_I_object_eemp_id_eemp",
                schema: "isdata",
                table: "I_object_eemp",
                column: "id_eemp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "I_division_object",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "I_Factory_Division",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "I_Factory_eemp");

            migrationBuilder.DropTable(
                name: "I_object_eemp",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "H_Division",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "H_Factory",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "H_eemp",
                schema: "isdata");

            migrationBuilder.DropTable(
                name: "H_object",
                schema: "isdata");

            migrationBuilder.CreateTable(
                name: "DataFiltrs",
                schema: "datalab",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateFiltrEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFiltrStart = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFiltrs", x => x.Id);
                });

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
    }
}
