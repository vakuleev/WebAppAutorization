using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ISData_relition_Satelits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_object_info",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_object_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "h_objectid_object",
                schema: "isdata",
                table: "S_object_info",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Factory_info",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "adress",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_eemp_info",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_eemp_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Division_info",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Division_info",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info",
                columns: new[] { "description", "load_dttm" });

            migrationBuilder.CreateTable(
                name: "S_eemp_cc",
                schema: "isdata",
                columns: table => new
                {
                    counter_coefficient = table.Column<int>(type: "int", nullable: false),
                    valid_from_dttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_eemp = table.Column<int>(type: "int", nullable: false),
                    valid_until_dttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_source = table.Column<int>(type: "int", nullable: false),
                    h_eempid_eemp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_S_eemp_cc", x => new { x.counter_coefficient, x.valid_from_dttm });
                    table.ForeignKey(
                        name: "FK_S_eemp_cc_H_eemp_h_eempid_eemp",
                        column: x => x.h_eempid_eemp,
                        principalSchema: "isdata",
                        principalTable: "H_eemp",
                        principalColumn: "id_eemp");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "7942ca50-d729-4042-8429-b5e7c3d81392", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1748), "0d0286cb-a846-4bef-9de2-4031e35118f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "47cf473e-b4cd-4c15-ab03-15580a5265f4", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(1971), "45972eee-9cd3-43f6-9fee-6b86c8114762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "6b77319e-e7d5-4c6a-952f-21459129af8e", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2005), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2004), "fc73ba48-cbc4-477a-9c28-1207e39c90a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e555027e-48fc-464d-a61a-938d7eaa779c", new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 10, 6, 15, 3, 46, 601, DateTimeKind.Local).AddTicks(2012), "3ce2d583-1442-4c1b-8fe4-093f5e4c5dc3" });

            migrationBuilder.CreateIndex(
                name: "IX_S_object_info_h_objectid_object",
                schema: "isdata",
                table: "S_object_info",
                column: "h_objectid_object");

            migrationBuilder.CreateIndex(
                name: "IX_S_Factory_info_h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info",
                column: "h_factoryid_factory");

            migrationBuilder.CreateIndex(
                name: "IX_S_eemp_info_h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info",
                column: "h_eempid_eemp");

            migrationBuilder.CreateIndex(
                name: "IX_S_Division_info_h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info",
                column: "h_divisionid_division");

            migrationBuilder.CreateIndex(
                name: "IX_S_eemp_cc_h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_cc",
                column: "h_eempid_eemp");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Division_info_H_Division_h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info",
                column: "h_divisionid_division",
                principalSchema: "isdata",
                principalTable: "H_Division",
                principalColumn: "id_division");

            migrationBuilder.AddForeignKey(
                name: "FK_S_eemp_info_H_eemp_h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info",
                column: "h_eempid_eemp",
                principalSchema: "isdata",
                principalTable: "H_eemp",
                principalColumn: "id_eemp");

            migrationBuilder.AddForeignKey(
                name: "FK_S_Factory_info_H_Factory_h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info",
                column: "h_factoryid_factory",
                principalSchema: "isdata",
                principalTable: "H_Factory",
                principalColumn: "id_factory");

            migrationBuilder.AddForeignKey(
                name: "FK_S_object_info_H_object_h_objectid_object",
                schema: "isdata",
                table: "S_object_info",
                column: "h_objectid_object",
                principalSchema: "isdata",
                principalTable: "H_object",
                principalColumn: "id_object");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_S_Division_info_H_Division_h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.DropForeignKey(
                name: "FK_S_eemp_info_H_eemp_h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropForeignKey(
                name: "FK_S_Factory_info_H_Factory_h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropForeignKey(
                name: "FK_S_object_info_H_object_h_objectid_object",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropTable(
                name: "S_eemp_cc",
                schema: "isdata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropIndex(
                name: "IX_S_object_info_h_objectid_object",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropIndex(
                name: "IX_S_Factory_info_h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropIndex(
                name: "IX_S_eemp_info_h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.DropIndex(
                name: "IX_S_Division_info_h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.DropColumn(
                name: "h_objectid_object",
                schema: "isdata",
                table: "S_object_info");

            migrationBuilder.DropColumn(
                name: "h_factoryid_factory",
                schema: "isdata",
                table: "S_Factory_info");

            migrationBuilder.DropColumn(
                name: "h_eempid_eemp",
                schema: "isdata",
                table: "S_eemp_info");

            migrationBuilder.DropColumn(
                name: "h_divisionid_division",
                schema: "isdata",
                table: "S_Division_info");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_object_info",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_object_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "adress",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Factory_info",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Factory_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_eemp_info",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_eemp_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "load_dttm",
                schema: "isdata",
                table: "S_Division_info",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                schema: "isdata",
                table: "S_Division_info",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_object_info",
                schema: "isdata",
                table: "S_object_info",
                column: "id_object");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Factory_info",
                schema: "isdata",
                table: "S_Factory_info",
                column: "id_factory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_eemp_info",
                schema: "isdata",
                table: "S_eemp_info",
                column: "id_eemp");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Division_info",
                schema: "isdata",
                table: "S_Division_info",
                column: "id_division");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "4e2b7e04-39d7-4eab-917c-2a68792feba2", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7330), "58b8e01f-fed9-4f75-ac15-4d105fc4a42c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "e15b31a6-8732-4fc2-825b-dca8ab0b49b7", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7366), "17849a3f-bcc4-421d-aefb-5127e526c906" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "1a7aef5b-a7a6-4006-b2e9-7940e0a2e01b", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7385), "f8b66436-efea-41d0-8332-5f03087a1259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DateFiltrEnd", "DateFiltrStart", "SecurityStamp" },
                values: new object[] { "bd67192e-c5d3-4b00-aaed-b2e8958fd6ea", new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 10, 6, 12, 51, 19, 344, DateTimeKind.Local).AddTicks(7393), "476871ca-b4c1-4951-a956-fdc8431d52b7" });
        }
    }
}
