using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAutorization.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfUserViewDeleteCreateAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Agents",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentCompanyId = table.Column<long>(type: "bigint", nullable: true),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    ViewDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EdIzm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SBDataLabs",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_nameUser1 = table.Column<int>(type: "int", nullable: false),
                    toniSandSlime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NGCementProc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    toniCementProc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    timeStartForceCement = table.Column<DateTime>(type: "datetime2", nullable: true),
                    timeEndForceCement = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateAt1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_nameUser2 = table.Column<int>(type: "int", nullable: false),
                    plotnSlimeInSB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    procentGipsInSB = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateAt2 = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SBDataLabs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUsers",
                columns: table => new
                {
                    companyId = table.Column<long>(type: "bigint", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUsers", x => new { x.companyId, x.userId });
                    table.ForeignKey(
                        name: "FK_CompanyUsers_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUsers_Companies_companyId",
                        column: x => x.companyId,
                        principalSchema: "data",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sheetfs",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prodavec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pokupat = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NumAct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateAct = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductEdIzm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductCount = table.Column<double>(type: "float", nullable: false),
                    ProductTarif = table.Column<double>(type: "float", nullable: false),
                    ProductStoim = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SumProductNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    companyId = table.Column<long>(type: "bigint", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DocType = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sheetfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sheetfs_Companies_companyId",
                        column: x => x.companyId,
                        principalSchema: "data",
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductEdIzm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductCount = table.Column<double>(type: "float", nullable: false),
                    ProductTarif = table.Column<double>(type: "float", nullable: false),
                    ProductStoim = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SumNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SumProductNalog = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    sheetfId = table.Column<long>(type: "bigint", nullable: false),
                    DocType = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Sheetfs_sheetfId",
                        column: x => x.sheetfId,
                        principalSchema: "data",
                        principalTable: "Sheetfs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Agents",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 2L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 3L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 4L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 5L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 6L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 7L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 8L, "Акционерное общество Новосибирскэнергосбыт" },
                    { 9L, "Акционерное общество Новосибирскэнергосбыт" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "IdentityRole", "Admin", "ADMIN" },
                    { "2", null, "IdentityRole", "Manager", "MANAGER" },
                    { "3", null, "IdentityRole", "Operator", "OPERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationId", "ConcurrencyStamp", "CurrentCompanyId", "Email", "EmailConfirmed", "FamilyName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SoftDelete", "TwoFactorEnabled", "UserName", "ViewDelete" },
                values: new object[,]
                {
                    { "1", 0, null, "a4d91f88-7f6d-4f9a-b4ef-4ef61b615a81", 0L, "s.isaev@ao-gns.ru", true, "Исаев", "Сергей", "Михайлович", false, null, "S.ISAEV@AO-GNS.RU", "ADMIN@AO-GNS.RU", "AQAAAAIAAYagAAAAEJ58FrHijBa/qNkGTIDE19UppJNfZh4Fa/fJzKMvCVYZPjg/7gZM35a9d+f6MqCxwA==", null, false, "c341ca03-f701-445c-8023-13f6675000e9", true, false, "admin@ao-gns.ru", false },
                    { "2", 0, null, "b2093d50-c38d-4d99-acb3-8eaa52e1b2a9", 0L, "s.isaev@ao-gns.ru", true, "Исаев", "Сергей", "Михайлович", false, null, "S.ISAEV@AO-GNS.RU", "S.ISAEV@AO-GNS.RU", "AQAAAAIAAYagAAAAEKsnd83sMpc8YYaqwCbYNkerkg3BYOFsM/x4FR91fdW4gsW5VFKWwNb0gDi4kTtPBQ==", "+79137673814", false, "8409dd98-c1ce-4526-b27b-ea4d73389069", true, false, "s.isaev@ao-gns.ru", false },
                    { "3", 0, null, "9f008738-b75c-4ca9-85d0-38a19993ad23", 0L, "GBI_GE@ao-gns.ru", true, "", "", "", false, null, "GBI_GE@AO-GNS.RU", "GBI_GE@AO-GNS.RU", "AQAAAAIAAYagAAAAEHyikk8XbS2mxeyEDe08XcJQaUFJnFWwLrijPQ5hFNIbU/ao2Vag1e0hcVYI/rmoSA==", "", false, "7756452e-e082-4df2-bf04-11fbbbfd875d", true, false, "GBI_GE@ao-gns.ru", false },
                    { "5", 0, null, "840332ab-43c0-4c98-b4f6-e794234aea4d", 0L, "kvlad1972@mail.ru", true, "Кулеев", "Владимир", "Александрович", false, null, "KVLAD1972@MAIL.RU", "KVLAD1972@MAIL.RU", "AQAAAAIAAYagAAAAELav6wL+1JdkgO5GtLF1HiiLlVx7baI4FdclKpPbKcG8vw+Hw/E77uIQumYMzFNHZA==", "+79139990407", false, "5e93b90b-cbbd-4be3-87a8-5d7c0c927b07", true, false, "kvlad1972@mail.ru", false }
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "АО \"Главновосибирскстрой\", завод \"Сибит\"" },
                    { 2L, "АО \"Главновосибирскстрой\", ОП завод \"Сибит Южный\"" },
                    { 3L, "АО \"ЛПК\"" },
                    { 4L, "ООО \"Пригородный\"" },
                    { 5L, "ООО \"Машкомплект\"" },
                    { 6L, "ООО \"ЖБИ-5\"" },
                    { 7L, "ООО \"Брикстоун\"" },
                    { 8L, "АО \"Искитимизвесть\"" },
                    { 9L, "ООО \"Новый век\" (ЖБИ-5)" }
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Products",
                columns: new[] { "Id", "EdIzm", "Name" },
                values: new object[,]
                {
                    { 1L, "кВт", "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность" },
                    { 2L, "кВт.ч", "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "1", "1", "UserRole" },
                    { "1", "2", "UserRole" },
                    { "3", "3", "UserRole" },
                    { "1", "5", "UserRole" }
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Sheetfs",
                columns: new[] { "Id", "Approved", "DateAct", "Delete", "DocType", "NumAct", "Pokupat", "Prodavec", "ProductCount", "ProductEdIzm", "ProductNalog", "ProductName", "ProductStoim", "ProductTarif", "SumNalog", "SumProductNalog", "companyId", "userId" },
                values: new object[,]
                {
                    { 1L, false, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "D", "128550-23-И33986", "ООО Новый век (ЖБИ-5)", "Акционерное общество Новосибирскэнергосбыт", 276593.0, "кВт.ч", 20m, "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию", null, 3.8308743893999999, null, null, 1L, "1" },
                    { 2L, false, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "D", "128550-23-И33987", "ООО Новый век (ЖБИ-5)", "Акционерное общество Новосибирскэнергосбыт", 176593.0, "кВт.ч", 20m, "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию", null, 3.8308743893999999, null, null, 1L, "1" }
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Orders",
                columns: new[] { "Id", "Delete", "DocType", "ProductCount", "ProductEdIzm", "ProductNalog", "ProductName", "ProductStoim", "ProductTarif", "SumNalog", "SumProductNalog", "sheetfId" },
                values: new object[,]
                {
                    { 1L, false, "D", 252.0, "кВт", 20m, "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность", 225721.87092m, 895.72171000000003, 45144.374184m, 270866.245104m, 1L },
                    { 2L, false, "D", 276593.0, "кВт.ч", 20m, "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию", 1059593.03998731m, 3.8308743893999999, 211918.607997462m, 1271511.647984772m, 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUsers_userId",
                table: "CompanyUsers",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_sheetfId",
                schema: "data",
                table: "Orders",
                column: "sheetfId");

            migrationBuilder.CreateIndex(
                name: "IX_Sheetfs_companyId",
                schema: "data",
                table: "Sheetfs",
                column: "companyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents",
                schema: "data");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompanyUsers");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "data");

            migrationBuilder.DropTable(
                name: "SBDataLabs",
                schema: "data");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Sheetfs",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "data");
        }
    }
}
