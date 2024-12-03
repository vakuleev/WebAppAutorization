using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class factoryeemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_I_object_eemp_H_Factory_H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp");

            migrationBuilder.DropIndex(
                name: "IX_I_object_eemp_H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp");

            migrationBuilder.DropColumn(
                name: "H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp");

            migrationBuilder.CreateTable(
                name: "H_FactoryH_eemp",
                schema: "isdata",
                columns: table => new
                {
                    H_Factorysid_factory = table.Column<int>(type: "int", nullable: false),
                    H_eempsid_eemp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_FactoryH_eemp", x => new { x.H_Factorysid_factory, x.H_eempsid_eemp });
                    table.ForeignKey(
                        name: "FK_H_FactoryH_eemp_H_Factory_H_Factorysid_factory",
                        column: x => x.H_Factorysid_factory,
                        principalSchema: "isdata",
                        principalTable: "H_Factory",
                        principalColumn: "id_factory",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_H_FactoryH_eemp_H_eemp_H_eempsid_eemp",
                        column: x => x.H_eempsid_eemp,
                        principalSchema: "isdata",
                        principalTable: "H_eemp",
                        principalColumn: "id_eemp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "0297c3fa-3422-4c71-92c0-69f40edce9c5", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1531), "216de533-70b5-4d5f-b1dd-e3fc1f01591c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "420e44b5-8d86-4da6-8321-e0643388e96b", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1569), "256e314f-6720-4c53-9f9f-a13207bf40fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7fc8c89e-b8ed-4204-91d8-12b5de4814c6", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1587), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1587), "ca83e69d-781d-40fa-9237-e356e5527595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "fcbea1f9-02c9-4f2a-91e6-b53c1a69ea48", new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 10, 16, 12, 1, 55, 437, DateTimeKind.Local).AddTicks(1595), "e4992534-4175-44c5-8b4a-daa3ec167636" });

            migrationBuilder.CreateIndex(
                name: "IX_H_FactoryH_eemp_H_eempsid_eemp",
                schema: "isdata",
                table: "H_FactoryH_eemp",
                column: "H_eempsid_eemp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "H_FactoryH_eemp",
                schema: "isdata");

            migrationBuilder.AddColumn<int>(
                name: "H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f81b9434-5dc4-41a3-9c43-dcb7b9a09df0", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7939), "00d698b7-e918-425a-8d22-647cbfea6e51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "5dab5eef-555e-48d8-be0a-7e2b948bffd2", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7978), "7c0b5a68-965c-4715-85b0-fb0f25c70edf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "d2894af6-591e-406a-bd5d-2b515bf87201", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(7998), "cd1a1dd7-c538-431a-a9d5-8cad6a4cfabd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "f5e3aa9d-f61e-4128-bf52-6fab3f1ad49f", new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(8006), new DateTime(2023, 10, 16, 10, 18, 26, 287, DateTimeKind.Local).AddTicks(8006), "44acf38e-68ad-41ec-bc12-6bca68d30200" });

            migrationBuilder.CreateIndex(
                name: "IX_I_object_eemp_H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp",
                column: "H_Factorysid_factory");

            migrationBuilder.AddForeignKey(
                name: "FK_I_object_eemp_H_Factory_H_Factorysid_factory",
                schema: "isdata",
                table: "I_object_eemp",
                column: "H_Factorysid_factory",
                principalSchema: "isdata",
                principalTable: "H_Factory",
                principalColumn: "id_factory",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
