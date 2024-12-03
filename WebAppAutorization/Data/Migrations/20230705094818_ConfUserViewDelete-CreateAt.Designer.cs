﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppAutorization.Data;

#nullable disable

namespace WebAppAutorization.Data.Migrations
{
    [DbContext(typeof(gnsDbContext))]
    [Migration("20230705094818_ConfUserViewDelete-CreateAt")]
    partial class ConfUserViewDeleteCreateAt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Operator",
                            NormalizedName = "OPERATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAppAutorization.Data.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<long?>("ApplicationId")
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CurrentCompanyId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("ViewDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a4d91f88-7f6d-4f9a-b4ef-4ef61b615a81",
                            CurrentCompanyId = 0L,
                            Email = "s.isaev@ao-gns.ru",
                            EmailConfirmed = true,
                            FamilyName = "Исаев",
                            FirstName = "Сергей",
                            LastName = "Михайлович",
                            LockoutEnabled = false,
                            NormalizedEmail = "S.ISAEV@AO-GNS.RU",
                            NormalizedUserName = "ADMIN@AO-GNS.RU",
                            PasswordHash = "AQAAAAIAAYagAAAAEJ58FrHijBa/qNkGTIDE19UppJNfZh4Fa/fJzKMvCVYZPjg/7gZM35a9d+f6MqCxwA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c341ca03-f701-445c-8023-13f6675000e9",
                            SoftDelete = true,
                            TwoFactorEnabled = false,
                            UserName = "admin@ao-gns.ru",
                            ViewDelete = false
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b2093d50-c38d-4d99-acb3-8eaa52e1b2a9",
                            CurrentCompanyId = 0L,
                            Email = "s.isaev@ao-gns.ru",
                            EmailConfirmed = true,
                            FamilyName = "Исаев",
                            FirstName = "Сергей",
                            LastName = "Михайлович",
                            LockoutEnabled = false,
                            NormalizedEmail = "S.ISAEV@AO-GNS.RU",
                            NormalizedUserName = "S.ISAEV@AO-GNS.RU",
                            PasswordHash = "AQAAAAIAAYagAAAAEKsnd83sMpc8YYaqwCbYNkerkg3BYOFsM/x4FR91fdW4gsW5VFKWwNb0gDi4kTtPBQ==",
                            PhoneNumber = "+79137673814",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8409dd98-c1ce-4526-b27b-ea4d73389069",
                            SoftDelete = true,
                            TwoFactorEnabled = false,
                            UserName = "s.isaev@ao-gns.ru",
                            ViewDelete = false
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f008738-b75c-4ca9-85d0-38a19993ad23",
                            CurrentCompanyId = 0L,
                            Email = "GBI_GE@ao-gns.ru",
                            EmailConfirmed = true,
                            FamilyName = "",
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "GBI_GE@AO-GNS.RU",
                            NormalizedUserName = "GBI_GE@AO-GNS.RU",
                            PasswordHash = "AQAAAAIAAYagAAAAEHyikk8XbS2mxeyEDe08XcJQaUFJnFWwLrijPQ5hFNIbU/ao2Vag1e0hcVYI/rmoSA==",
                            PhoneNumber = "",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7756452e-e082-4df2-bf04-11fbbbfd875d",
                            SoftDelete = true,
                            TwoFactorEnabled = false,
                            UserName = "GBI_GE@ao-gns.ru",
                            ViewDelete = false
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "840332ab-43c0-4c98-b4f6-e794234aea4d",
                            CurrentCompanyId = 0L,
                            Email = "kvlad1972@mail.ru",
                            EmailConfirmed = true,
                            FamilyName = "Кулеев",
                            FirstName = "Владимир",
                            LastName = "Александрович",
                            LockoutEnabled = false,
                            NormalizedEmail = "KVLAD1972@MAIL.RU",
                            NormalizedUserName = "KVLAD1972@MAIL.RU",
                            PasswordHash = "AQAAAAIAAYagAAAAELav6wL+1JdkgO5GtLF1HiiLlVx7baI4FdclKpPbKcG8vw+Hw/E77uIQumYMzFNHZA==",
                            PhoneNumber = "+79139990407",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5e93b90b-cbbd-4be3-87a8-5d7c0c927b07",
                            SoftDelete = true,
                            TwoFactorEnabled = false,
                            UserName = "kvlad1972@mail.ru",
                            ViewDelete = false
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Agent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Agents", "data");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        },
                        new
                        {
                            Id = 9L,
                            Name = "Акционерное общество Новосибирскэнергосбыт"
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Companies", "data");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "АО \"Главновосибирскстрой\", завод \"Сибит\""
                        },
                        new
                        {
                            Id = 2L,
                            Name = "АО \"Главновосибирскстрой\", ОП завод \"Сибит Южный\""
                        },
                        new
                        {
                            Id = 3L,
                            Name = "АО \"ЛПК\""
                        },
                        new
                        {
                            Id = 4L,
                            Name = "ООО \"Пригородный\""
                        },
                        new
                        {
                            Id = 5L,
                            Name = "ООО \"Машкомплект\""
                        },
                        new
                        {
                            Id = 6L,
                            Name = "ООО \"ЖБИ-5\""
                        },
                        new
                        {
                            Id = 7L,
                            Name = "ООО \"Брикстоун\""
                        },
                        new
                        {
                            Id = 8L,
                            Name = "АО \"Искитимизвесть\""
                        },
                        new
                        {
                            Id = 9L,
                            Name = "ООО \"Новый век\" (ЖБИ-5)"
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.CompanyUser", b =>
                {
                    b.Property<long?>("companyId")
                        .HasColumnType("bigint");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("companyId", "userId");

                    b.HasIndex("userId");

                    b.ToTable("CompanyUsers", (string)null);
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<string>("DocType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<double>("ProductCount")
                        .HasColumnType("float");

                    b.Property<string>("ProductEdIzm")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("ProductStoim")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("ProductTarif")
                        .HasColumnType("float");

                    b.Property<decimal?>("SumNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SumProductNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("sheetfId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("sheetfId");

                    b.ToTable("Orders", "data");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Delete = false,
                            DocType = "D",
                            ProductCount = 252.0,
                            ProductEdIzm = "кВт",
                            ProductNalog = 20m,
                            ProductName = "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность",
                            ProductStoim = 225721.87092m,
                            ProductTarif = 895.72171000000003,
                            SumNalog = 45144.374184m,
                            SumProductNalog = 270866.245104m,
                            sheetfId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Delete = false,
                            DocType = "D",
                            ProductCount = 276593.0,
                            ProductEdIzm = "кВт.ч",
                            ProductNalog = 20m,
                            ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                            ProductStoim = 1059593.03998731m,
                            ProductTarif = 3.8308743893999999,
                            SumNalog = 211918.607997462m,
                            SumProductNalog = 1271511.647984772m,
                            sheetfId = 1L
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("EdIzm")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Products", "data");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EdIzm = "кВт",
                            Name = "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность"
                        },
                        new
                        {
                            Id = 2L,
                            EdIzm = "кВт.ч",
                            Name = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию"
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.SBDataLab", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateAt1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAt2")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("NGCementProc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("id_nameUser1")
                        .HasColumnType("int");

                    b.Property<int>("id_nameUser2")
                        .HasColumnType("int");

                    b.Property<decimal?>("plotnSlimeInSB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("procentGipsInSB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("timeEndForceCement")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("timeStartForceCement")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("toniCementProc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("toniSandSlime")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SBDataLabs", "data");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Sheetf", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DateAct")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<string>("DocType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("NumAct")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pokupat")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Prodavec")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("ProductCount")
                        .HasColumnType("float");

                    b.Property<string>("ProductEdIzm")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("ProductStoim")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("ProductTarif")
                        .HasColumnType("float");

                    b.Property<decimal?>("SumNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SumProductNalog")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("companyId")
                        .HasColumnType("bigint");

                    b.Property<string>("userId")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("companyId");

                    b.ToTable("Sheetfs", "data");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Approved = false,
                            DateAct = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delete = false,
                            DocType = "D",
                            NumAct = "128550-23-И33986",
                            Pokupat = "ООО Новый век (ЖБИ-5)",
                            Prodavec = "Акционерное общество Новосибирскэнергосбыт",
                            ProductCount = 276593.0,
                            ProductEdIzm = "кВт.ч",
                            ProductNalog = 20m,
                            ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                            ProductTarif = 3.8308743893999999,
                            companyId = 1L,
                            userId = "1"
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            DateAct = new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Delete = false,
                            DocType = "D",
                            NumAct = "128550-23-И33987",
                            Pokupat = "ООО Новый век (ЖБИ-5)",
                            Prodavec = "Акционерное общество Новосибирскэнергосбыт",
                            ProductCount = 176593.0,
                            ProductEdIzm = "кВт.ч",
                            ProductNalog = 20m,
                            ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                            ProductTarif = 3.8308743893999999,
                            companyId = 1L,
                            userId = "1"
                        });
                });

            modelBuilder.Entity("WebAppAutorization.Data.Identity.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Identity.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.HasDiscriminator().HasValue("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        },
                        new
                        {
                            UserId = "5",
                            RoleId = "1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppAutorization.Data.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.CompanyUser", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Tables.Company", "company")
                        .WithMany("CompanyUsers")
                        .HasForeignKey("companyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppAutorization.Data.Identity.User", "user")
                        .WithMany("CompanyUsers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("company");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Order", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Tables.Sheetf", "Sheetf")
                        .WithMany("Orders")
                        .HasForeignKey("sheetfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sheetf");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Sheetf", b =>
                {
                    b.HasOne("WebAppAutorization.Data.Tables.Company", "Company")
                        .WithMany("Sheetfs")
                        .HasForeignKey("companyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Identity.User", b =>
                {
                    b.Navigation("CompanyUsers");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Company", b =>
                {
                    b.Navigation("CompanyUsers");

                    b.Navigation("Sheetfs");
                });

            modelBuilder.Entity("WebAppAutorization.Data.Tables.Sheetf", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
