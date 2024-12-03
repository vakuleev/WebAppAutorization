using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Principal;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Data.Tables;
using Microsoft.Identity.Client.Extensions;//.Role;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using WebAppAutorization.Data.ISData;
using DocumentFormat.OpenXml.Bibliography;
//using Antlr.Runtime.Misc;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace WebAppAutorization.Data
{

    public class gnsDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        protected readonly IConfiguration Configuration;

        public gnsDbContext(DbContextOptions<gnsDbContext> options, IConfiguration configuration)
            : base(options)
        {
            //Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // В Н И М А Н И Е: данный метод определения свойств имеет приоритет над определением в классах (таблицах) //
            //---------------------------------------------------------------------------------------------------------//

            //modelBuilder.Entity<Sheetf>().Property(s => s.SheetfId).UseIdentityColumn();
            //modelBuilder.Entity<Sheetf>().Property(s => s.Prodavec).HasMaxLength(100);
            //modelBuilder.Entity<Sheetf>().Property(s => s.Pokupat).HasMaxLength(100);
            //modelBuilder.Entity<Sheetf>().Property(s => s.NumAct).HasMaxLength(100);

            //modelBuilder.Entity<Sheetf>().Property(s=>s.CreateAt).HasDefaultValue<DateTime?>();
            //modelBuilder.Entity<Sheetf>().Property(s=>s.CreateAt).HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<SBDataLab>().Property(s => s.CreateAt1).HasDefaultValueSql("GETDATE()");
            //modelBuilder.Entity<SBDataLab>().Property(s => s.CreateAt2).HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<ApplicationIdentityUser>()
            //.Property(a => a.Id).ValueGeneratedOnAdd();
            //modelBuilder.Entity<ApplicationIdentityUser>()
            //.Property(a => a.ApplicationId).ValueGeneratedOnAdd();

            //modelBuilder.Entity<Order>().Property(o => o.CreateAt).HasDefaultValueSql("GETDATE()");
            // данный метод определения свойств имеет приоритет над определением в классах (таблицах)
            //---------------------------------------------------------------------------------------------------------//
            // В Н И М А Н И Е: данный метод определения свойств имеет приоритет над определением в классах (таблицах) //


            // В Н И М А Н И Е: Построение связи один ко многим - КАСКАДНОЕ УДАЛЕНИЕ ! ----------------//
            // ВАЖНО если при сохранении изменения таблиц не происходит-> -----------------------------//
            //-переход в листинг строк значит связь выполонена НЕВЕРНО!!! -----------------------------//
            //РАБОТАЕТ для одной связи одна-Sheetf -> много-Order -------------------------WORK--------//
            //modelBuilder.Entity<Order>()
            //    // Настройка связи между таблицами один ко многим
            //    .HasOne<Sheetf>(o => o.Sheetf)
            //    .WithMany(s => s.Orders)
            //    // Указание внешнего ключа
            //    .HasForeignKey(o => o.sheetfId);
            //РАБОТАЕТ для одной связи одна-Sheetf -> много-Order -------------------------WORK--------//


            //РАБОТАЕТ для двух связей: одна-Sheetf -> много-Order | одна-Shablon -> много-Order --WORK//
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Shablon)
            //    .WithMany(s => s.Orders);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Sheetf)
                .WithMany(s => s.Orders);
            //РАБОТАЕТ для двух связей: одна-Sheetf -> много-Order | одна-Shablon -> много-Order --WORK//

            // В Н И М А Н И Е: Построение связи один ко многим - КАСКАДНОЕ УДАЛЕНИЕ ! ----------------//

            //modelBuilder.Entity<Shablon>()
            //    // Настройка связи между таблицами один ко многим
            //    .HasOne<Company>(o => o.Company)
            //    .WithMany(s => s.Shablons)
            //    // Указание внешнего ключа
            //    .HasForeignKey(o => o.Company_Id);

            //.HasConstraintName("Company_Shablon_UD_Key");
            //       .OnDelete(DeleteBehavior.Restrict);
            //       .IsRequired(true); //ReferentialAction.Restrict

            //modelBuilder.Entity<Sheetf>()
            //   // Настройка связи между таблицами один ко многим
            //   .HasOne<Company>(o => o.Company_sheetf)
            //   .WithMany(s => s.Sheetfs)
            //   // Указание внешнего ключа
            //   .HasForeignKey(o => o.Company_sheetf_Id);
            //.HasConstraintName("Company_Sheetf_UD_Key");
            //.OnDelete(DeleteBehavior.Restrict);
            //.IsRequired(true); //ReferentialAction.Restrict
            //Как сделать [ForeignKey(string name)]  [InverseProperty(string property)]
            //https://andrey.moveax.ru/post/mvc3-in-depth-entity-framework-04-code-first-attributes

            //https://stackoverflow.com/questions/11036720/multiple-one-to-many-relationships-with-entity-framework
            modelBuilder.Entity<Company>()
                .HasMany(u => u.Sheetfs)
                .WithOne(m => m.Company);
            //.HasOne(u => u.Sheetfs)  // or HasRequired
            //.WithMany();
            //.HasForeignKey(u => u.Company_Id);

            //modelBuilder.Entity<Company>()
            //    .HasMany(u => u.Shablons)
            //    .WithOne(m => m.Company);
            ////.HasOne(u => u.Shablons)  // or HasRequired
            ////.WithMany();
            ////.HasForeignKey(u => u.Company_Id);


            //modelBuilder.Entity<Company>()
            //    .HasMany<Sheetf>(o => o.Sheetfs)
            //    .WithOne(s => s.Company_sheetf)
            //    //.HasForeignKey(o => o.Company_sheetf_Id)
            //    .UsingEntity<Shablon>(j => j
            //         .HasMany(pt => pt.Shablons)
            //         .WithOne(t => t.Company_shablon)
            //         .HasForeignKey(pt => pt.Company_shablon_Id);
            //      );


            /*
            //-----------------------------------------------------------------------------------------//
            //Настройка ApplicationIdentityUser один -> ко многим UserCompany
            modelBuilder.Entity<CompanyUser>()
                // Настройка связи между таблицами один ко многим
                .HasOne<ApplicationIdentityUser>(c => c.ApplicationIdentityUsers)
                .WithMany(c => c.CompanyUsers)
                // Указание внешнего ключа
                .HasForeignKey(c => c.UserId);
            //Настройка Company один -> ко многим UserCompany
            modelBuilder.Entity<CompanyUser>()
                // Настройка связи между таблицами один ко многим
                .HasOne<Company>(c => c.Companies)
                .WithMany(c => c.CompanyUsers)
                // Указание внешнего ключа
                .HasForeignKey(c => c.CompanyId);
            //-----------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------//
            // Настройка связи между таблицами многие ко многим
            modelBuilder.Entity<ApplicationIdentityUser>(b => {
                // Primary key
                b.HasKey(u => u.Id);
                // У каждого ApplicationIdentityUser может быть много записей в таблице соединений CompanyUser
                b.HasMany<CompanyUser>().WithOne().HasForeignKey(u => u.UserId).IsRequired();
            });
            // Настройка связи между таблицами многие ко многим
            modelBuilder.Entity<Company>(b => {
                // Primary key
                b.HasKey(u => u.Id);
                // У каждой Company может быть много записей в таблице соединений CompanyUser
                b.HasMany<CompanyUser>().WithOne().HasForeignKey(u => u.CompanyId).IsRequired();
            });
            //-----------------------------------------------------------------------------------------//
            //*///

            //modelBuilder.Entity<CompanyUser>(b =>
            //{
            //    b.HasOne<Company>()
            //        .WithMany()
            //        .HasForeignKey(cu => cu.companyId)        //"CompanyId"
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .IsRequired();
            //
            //    b.HasOne<User>()
            //        .WithMany()
            //        .HasForeignKey(cu => cu.userId)           //"UserId")
            //        .OnDelete(DeleteBehavior.Cascade)
            //        .IsRequired();
            //});

            // Настройка связи между таблицами Company CompanyUser многие Company ко многим User
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Users)
                .WithMany(s => s.Companies)
                .UsingEntity<CompanyUser>(j => j
                     .HasOne(pt => pt.company)
                     .WithMany(t => t.CompanyUsers)
                     .HasForeignKey(pt => pt.companyId)
                 );
            // Настройка связи между таблицами User CompanyUser многие User ко многим Company
            modelBuilder.Entity<User>()
                .HasMany(c => c.Companies)
                .WithMany(s => s.Users)
                .UsingEntity<CompanyUser>(j => j
                     .HasOne(pt => pt.user)
                     .WithMany(t => t.CompanyUsers)
                     .HasForeignKey(pt => pt.userId)
                 );

            //Настройка для таблицы CompanyUsers ключа Primary key ------------------------------------//
            modelBuilder.Entity<CompanyUser>(b =>
            {   // Primary key
                b.HasKey(r => new { r.companyId, r.userId });
                // Сопоставляется с таблицей CompanyUsers
                b.ToTable("CompanyUsers");
            });
            //Настройка для таблицы CompanyUsers ключа Primary key ------------------------------------//


            //---------------------------------------- Х А Б    H_Factory    ->    Х А Б    H_Division ------------------------------------------------------------------------//
            // Настройка связи между таблицами H_Factory I_Factory_Division многие H_Division ко многим H_Factory
            modelBuilder.Entity<H_Factory>()
                .HasMany(d => d.H_Divisions)
                .WithMany(f => f.H_Factorys)
                .UsingEntity<I_Factory_Division>(j => j
                     .HasOne(fd => fd.h_factory)
                     .WithMany(t => t.I_Factory_Divisions)
                     .HasForeignKey(fd => fd.id_factory)
                 );

            // Настройка связи между таблицами H_Division I_Factory_Division многие H_Factory ко многим H_Division 
            modelBuilder.Entity<H_Division>()
                .HasMany(f => f.H_Factorys)
                .WithMany(d => d.H_Divisions)
                .UsingEntity<I_Factory_Division>(j => j
                     .HasOne(fd => fd.h_division)
                     .WithMany(t => t.I_Factory_Divisions)
                     .HasForeignKey(fd => fd.id_division)
                 );
            //                                 

            //Настройка для таблицы I_Factory_Division ключа Primary key ------------------------------------//
            modelBuilder.Entity<I_Factory_Division>(b =>
            {   // Primary key        
                b.HasKey(r => new { r.id_factory, r.id_division });
                // Сопоставляется с таблицей I_Factory_Division
                b.ToTable("I_Factory_Division", "isdata");
            });
            //Настройка для таблицы I_Factory_Division ключа Primary key ------------------------------------//

            //---------------------------------------- Х А Б    H_Factory    ->    Х А Б    H_Division ------------------------------------------------------------------------//


            //---------------------------------------- Х А Б    H_Division    ->    Х А Б    H_objeect ------------------------------------------------------------------------//
            // Настройка связи между таблицами H_Division I_division_object многие H_Division ко многим H_object
            modelBuilder.Entity<H_Division>()
                .HasMany(d => d.H_objects)
                .WithMany(f => f.H_Divisions)
                .UsingEntity<I_division_object>(j => j
                     .HasOne(fd => fd.h_division)
                     .WithMany(t => t.I_division_objects)
                     .HasForeignKey(fd => fd.id_division)
                 );

            // Настройка связи между таблицами H_objeect I_division_object многие H_objeect ко многим H_Division 
            modelBuilder.Entity<H_object>()
                .HasMany(f => f.H_Divisions)
                .WithMany(d => d.H_objects)
                .UsingEntity<I_division_object>(j => j
                     .HasOne(fd => fd.h_object)
                     .WithMany(t => t.I_division_objects)
                     .HasForeignKey(fd => fd.id_object)
                 );
            //                                 

            //Настройка для таблицы I_division_object ключа Primary key ------------------------------------//
            modelBuilder.Entity<I_division_object>(b =>
            {   // Primary key        
                b.HasKey(r => new { r.id_division, r.id_object });
                // Сопоставляется с таблицей I_division_object
                b.ToTable("I_division_object", "isdata");
            });
            //Настройка для таблицы I_division_object ключа Primary key ------------------------------------//

            //---------------------------------------- Х А Б    H_Division    ->    Х А Б    H_objeect ------------------------------------------------------------------------//


            //---------------------------------------- Х А Б    H_object    ->    Х А Б    H_eemp      ------------------------------------------------------------------------//
            // Настройка связи между таблицами H_object I_object_eemp многие H_object ко многим H_eemp
            modelBuilder.Entity<H_object>()
                .HasMany(d => d.H_eemps)
                .WithMany(f => f.H_objects)
                .UsingEntity<I_object_eemp>(j => j
                     .HasOne(fd => fd.h_object)
                     .WithMany(t => t.I_object_eemps)
                     .HasForeignKey(fd => fd.id_object)
                 );

            // Настройка связи между таблицами H_eemp I_object_eemp многие H_eemp ко многим H_object 
            modelBuilder.Entity<H_eemp>()
                .HasMany(f => f.H_objects) // было H_Factorys - ОШИБКА
                .WithMany(d => d.H_eemps)
                .UsingEntity<I_object_eemp>(j => j
                     .HasOne(fd => fd.h_eemp)
                     .WithMany(t => t.I_object_eemps)
                     .HasForeignKey(fd => fd.id_eemp)
                 );
            //                                 

            //Настройка для таблицы I_object_eemp ключа Primary key ------------------------------------//
            modelBuilder.Entity<I_object_eemp>(b =>
            {   // Primary key        
                b.HasKey(r => new { r.id_object, r.id_eemp });
                // Сопоставляется с таблицей I_object_eemp
                b.ToTable("I_object_eemp", "isdata");
            });
            //Настройка для таблицы I_object_eemp ключа Primary key ------------------------------------//

            //---------------------------------------- Х А Б    H_object    ->    Х А Б    H_eemp      ------------------------------------------------------------------------//

            //Настройка для таблицы I_Factory_eemp ключа Primary key     ------------------------------------//
            modelBuilder.Entity<I_Factory_eemp>(b =>
            {   // Primary key        
                b.HasKey(r => new { r.id_factory, r.id_eemp });
                // Сопоставляется с таблицей I_Factory_eemp
                b.ToTable("I_Factory_eemp", "isdata");
            });
            //Настройка для таблицы I_Factory_Division ключа Primary key ------------------------------------//

            //---------------------------------------- Х А Б    H_object    ->    Х А Б    H_eemp      ------------------------------------------------------------------------//



            //---------------------------------------- Х А Б   H_Division     ->    Х А Б    H_eemp     ------------------------------------------------------------------------//

            //Настройка для таблицы I_division_eemp ключа Primary key     ------------------------------------//
            modelBuilder.Entity<I_Division_eemp>(b =>
            {   // Primary key        
                b.HasKey(r => new { r.id_division, r.id_eemp });
                // Сопоставляется с таблицей I_Factory_eemp
                b.ToTable("I_Division_eemp", "isdata");
            });
            //Настройка для таблицы I_Factory_Division ключа Primary key ------------------------------------//

            //---------------------------------------- Х А Б   H_Division     ->    Х А Б    H_eemp     ------------------------------------------------------------------------//

            ////Настройка для таблицы S_Division_info  без Primary key     ------------------------------------//
            //modelBuilder.Entity<S_Division_info>(b =>
            //{           
            //    b.HasNoKey();
            //    // Сопоставляется с таблицей S_Division_info
            //    b.ToTable("S_Division_infos");
            //});
            ////Настройка для таблицы S_Division_info  без Primary key     ------------------------------------//

            //Настройка для таблицы H_Factory  Ограничений на уникальность             ------------------------//
            modelBuilder.Entity<H_Factory>(b =>
            {           
                b.HasAlternateKey(r => r.name_factory );
                b.ToTable("H_Factory", "isdata");
            });

            //Настройка для таблицы H_Division  Ограничений на уникальность            ------------------------//
            modelBuilder.Entity<H_Division>(b =>
            {           
                b.HasAlternateKey(r => new { r.prefix, r.name_division });
                b.ToTable("H_Division", "isdata");
            });

            //Настройка для таблицы H_object  Ограничений на уникальность              ------------------------//
            modelBuilder.Entity<H_object>(b =>
            {           
                b.HasAlternateKey(r => new { r.prefix, r.name_object });
                b.ToTable("H_object", "isdata");
            });

            //Настройка для таблицы H_eemp  Ограничений на уникальность               ------------------------//
            modelBuilder.Entity<H_eemp>(b =>
            {           
                b.HasAlternateKey(r => new { r.prefix, r.name_point });
                b.ToTable("H_eemp", "isdata");
            });


            //--------------------                      Определение    PK  для сателитов                    ------------------------//
            modelBuilder.Entity<S_Factory_info>(b =>
            {
                //b.HasKey(s => new { s.description, s.load_dttm });
                b.HasKey(s => new { s.load_dttm });
                b.ToTable("S_Factory_info", "isdata")
                 .Property(p => p.load_dttm).IsConcurrencyToken();  
            });

            modelBuilder.Entity<S_Division_info>(b =>
            {
                //b.HasKey(s => new { s.description, s.load_dttm });
                b.HasKey(s => new { s.load_dttm });
                b.ToTable("S_Division_info", "isdata");
                // .Property(p => p.load_dttm).IsConcurrencyToken();  
            });
            //modelBuilder.Entity<S_Division_info>()
            //      .Property(p => p.load_dttm).IsConcurrencyToken();

            modelBuilder.Entity<S_object_info>(b =>
            {
                //b.HasKey(s => new { s.description, s.load_dttm });
                b.HasKey(s => new { s.load_dttm });
                b.ToTable("S_object_info", "isdata");
            });
            modelBuilder.Entity<S_eemp_info>(b =>
            {
                //b.HasKey(s => new { s.description, s.load_dttm });
                b.HasKey(s => new { s.load_dttm });
                b.ToTable("S_eemp_info", "isdata");
            });
            modelBuilder.Entity<S_eemp_cc>(b =>
            {
                b.HasKey(s => new { s.counter_coefficient, s.valid_from_dttm });
                b.ToTable("S_eemp_cc", "isdata");
            });
            //--------------------                      Определение    PK  для сателитов                    ------------------------//


            //--------------------                      С В Я З Ь    О Д Н А      ко       М Н О Г И М     ------------------------//
            // Настройка связи между таблицами H_Factory один ко многие S_Factory_info
            modelBuilder.Entity<S_Factory_info>()
                .HasOne(o => o.h_factory)
                .WithMany(s => s.S_Factory_infos);
            // Настройка связи между таблицами H_Division один ко многие S_Division_info
            modelBuilder.Entity<S_Division_info>()
                .HasOne(o => o.h_division)
                .WithMany(s => s.S_Division_infos);
            // Настройка связи между таблицами H_object один ко многие S_object_info
            modelBuilder.Entity<S_object_info>()
                .HasOne(o => o.h_object)
                .WithMany(s => s.S_object_infos);
            // Настройка связи между таблицами H_eemp один ко многие S_eemp_info
            modelBuilder.Entity<S_eemp_info>()
                .HasOne(o => o.h_eemp)
                .WithMany(s => s.S_eemp_infos);
            // Настройка связи между таблицами H_eemp один ко многие S_eemp_cc
            modelBuilder.Entity<S_eemp_cc>()
                .HasOne(o => o.h_eemp)
                .WithMany(s => s.S_eemp_ccs);
            //--------------------                      С В Я З Ь    О Д Н А      ко       М Н О Г И М     ------------------------//


            // Создадим администратора с логином admin@ao-gns.ru  (пароль 123 зашифрованный в PasswordHash)
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = "1",
                        //s.isaev@ao-gns.ru 
                        UserName = "admin@ao-gns.ru",
                        NormalizedUserName = "ADMIN@AO-GNS.RU",
                        Email = "s.boss@ao-gns.ru",
                        NormalizedEmail = "S.BOSS@AO-GNS.RU",
                        // Данное поле подтверждает разрешение на вход пользователя в приложение при аутоидентификаци
                        EmailConfirmed = true,  
                        FamilyName = "Шеф",
                        FirstName = "Босс",
                        LastName = "Михайлович",
                        //Password   = "123"
                        PasswordHash = "AQAAAAIAAYagAAAAEJ58FrHijBa/qNkGTIDE19UppJNfZh4Fa/fJzKMvCVYZPjg/7gZM35a9d+f6MqCxwA=="
                        //Password   = "As#$54"
                        //PasswordHash = "AQAAAAIAAYagAAAAEN9+FHFyZJgFRaqbDWA0XHruOLi5aBZB4watPa5CJoARjLihPtsQjXis4UCJ1P5iqw=="
                        //Password   = "Admin#$54"
                        //PasswordHash = "AQAAAAIAAYagAAAAEMt+mClxotNVhpr5hF5Ne9o/xmOgrN046+Ebdhy5rZrbxJwOF2p6O3Jg0cP/bUUBcQ=="
                        //Password   = "ASdf54$%54"
                        //PasswordHash = "AQAAAAIAAYagAAAAEKY/HSPLA2a5q4UYcTihJemchiKiU4wJZusG7zImVLid0G+0LnB6sbupAeBXJiQQJw=="
                        //Password   = "SAdmin#$54"
                        //PasswordHash = "AQAAAAIAAYagAAAAEFWD+EFi2RTCC/7n2n7KBsF0lmM1Uzi2X+4s5EV+gNoCnTGjCHV+Zu8IyfQnyn+fnw=="
                    },
                    new User
                    {
                        Id = "2",
                        //s.isaev@ao-gns.ru 
                        UserName = "s.boss@ao-gns.ru",
                        NormalizedUserName = "S.BOSS@AO-GNS.RU",
                        Email = "s.boss@ao-gns.ru",
                        NormalizedEmail = "S.BOSS@AO-GNS.RU",
                        PhoneNumber = "+79130000000",
                        // Данное поле подтверждает разрешение на вход пользователя в приложение при аутоидентификаци
                        EmailConfirmed = true,
                        FamilyName = "Shef",
                        FirstName = "Boss",
                        LastName = "Михайлович",
                        //Password   = "####"
                        PasswordHash = "AQAAAAIAAYagAAAAEKsnd83sMpc8YYaqwCbYNkerkg3BYOFsM/x4FR91fdW4gsW5VFKWwNb0gDi4kTtPBQ=="
                    },
                    new User
                    {
                        Id = "3",
                        UserName = "GBI_GE@ao-gns.ru",
                        NormalizedUserName = "GBI_GE@AO-GNS.RU",
                        Email = "GBI_GE@ao-gns.ru",
                        NormalizedEmail = "GBI_GE@AO-GNS.RU",
                        PhoneNumber = "",
                        // Данное поле подтверждает разрешение на вход пользователя в приложение при аутоидентификаци
                        EmailConfirmed = true,
                        FamilyName = "",
                        FirstName = "",
                        LastName = "",
                        //Password   = "####"
                        PasswordHash = "AQAAAAIAAYagAAAAEHyikk8XbS2mxeyEDe08XcJQaUFJnFWwLrijPQ5hFNIbU/ao2Vag1e0hcVYI/rmoSA=="
                    },
                    new User
                    {
                        Id = "5",
                        UserName = "kvlad1972@mail.ru",
                        NormalizedUserName = "KVLAD1972@MAIL.RU",
                        Email = "kvlad1972@mail.ru",
                        NormalizedEmail = "KVLAD1972@MAIL.RU",
                        PhoneNumber = "+79139990407",
                        // Данное поле подтверждает разрешение на вход пользователя в приложение при аутоидентификаци
                        EmailConfirmed = true,
                        FamilyName = "Кулеев",
                        FirstName = "Владимир",
                        LastName = "Александрович",
                        //Password   = "KVa317#$54"
                        PasswordHash = "AQAAAAIAAYagAAAAELav6wL+1JdkgO5GtLF1HiiLlVx7baI4FdclKpPbKcG8vw+Hw/E77uIQumYMzFNHZA=="
                    }

                    );
            // Создадим роли Admin Manager Operator
            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Id = "2", Name = "Manager", NormalizedName = "MANAGER" },
                    new IdentityRole { Id = "3", Name = "Operator", NormalizedName = "OPERATOR" }
                    );
            // Назначим пользователю UserId = "1" (s.isaev@ao-gns.ru)  роль RoleId = "1" (Admin)
            // ВАЖНО -> после add-migration в  gnsDbContextModelSnapshot для ApplicationUserRole 
            // НУЖНО ДОБАВИТЬ    onDelete: ReferentialAction.Restrict); NoAction

            modelBuilder.Entity<UserRole>().HasData(
                    //UserIdRoleId = "11",   
                    new UserRole { UserId = "1", RoleId = "1" },
                    new UserRole { UserId = "2", RoleId = "1" },
                    new UserRole { UserId = "3", RoleId = "3" },
                    new UserRole { UserId = "5", RoleId = "1" }
                    );
            // Создадим тестовые данные для проверки работоспособности связей таблиц
            modelBuilder.Entity<Sheetf>().HasData(
                    new Sheetf
                    {
                        Id = 1,
                        Prodavec = "Акционерное общество Новосибирскэнергосбыт",
                        Pokupat = "ООО Новый век (ЖБИ-5)",
                        NumAct = "128550-23-И33986",
                        DateAct = Convert.ToDateTime(DateTime.Now.ToString("d")),
                        ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                        ProductCount = 276593.00,
                        ProductEdIzm = "кВт.ч",
                        ProductTarif = 3.8308743894,
                        ProductNalog = 20M,
                        userId = "1",
                        companyId = 1,
                        Approved = false//,
                        //CreateAt = Convert.ToDateTime(DateTime.Now.ToString())
                    },
                    new Sheetf
                    {
                        Id = 2,
                        Prodavec = "Акционерное общество Новосибирскэнергосбыт",
                        Pokupat = "ООО Новый век (ЖБИ-5)",
                        NumAct = "128550-23-И33987",
                        DateAct = Convert.ToDateTime(DateTime.Now.ToString("d")),
                        ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                        ProductCount = 176593.00,
                        ProductEdIzm = "кВт.ч",
                        ProductTarif = 3.8308743894,
                        ProductNalog = 20M,
                        userId = "1",
                        companyId = 1,
                        Approved = false//,
                        //CreateAt = Convert.ToDateTime(DateTime.Now.ToString())
                    });

            modelBuilder.Entity<Order>().HasData(
                    new Order
                    {
                        Id = 1,
                        ProductName = "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность",
                        ProductCount = 252.00,
                        ProductEdIzm = "кВт",
                        ProductTarif = 895.72171,
                        ProductNalog = 20M,
                        sheetfId = 1
                    },
                    new Order
                    {
                        Id = 2,
                        ProductName = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию",
                        ProductCount = 276593.00,
                        ProductEdIzm = "кВт.ч",
                        ProductTarif = 3.8308743894,
                        ProductNalog = 20M,
                        sheetfId = 1

                    });
            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "Электрическая мощность-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за мощность", EdIzm = "кВт" },
                    new Product { Id = 2, Name = "Электрическая энергия-3-я ценовая категория (СН2) от 670кВт по 10МВт ставка за энергию", EdIzm = "кВт.ч" }
                    );
            modelBuilder.Entity<Company>().HasData(
                    new Company { Id = 1,  Name = "АО \"Главновосибирскстрой\", завод \"Сибит\"" },
                    new Company { Id = 2,  Name = "АО \"Главновосибирскстрой\", ОП завод \"Сибит Южный\"" },
                    new Company { Id = 3,  Name = "АО \"ЛПК\"" },
                    new Company { Id = 4,  Name = "ООО \"Пригородный\"" },
                    new Company { Id = 5,  Name = "ООО \"Машкомплект\"" },
                    new Company { Id = 6,  Name = "ООО \"ЖБИ-5\"" },
                    new Company { Id = 7,  Name = "ООО \"Брикстоун\"" },
                    new Company { Id = 8,  Name = "АО \"Искитимизвесть\"" },
                    new Company { Id = 9,  Name = "ООО \"Новый век\" (ЖБИ-5)" }
                    );
            modelBuilder.Entity<Agent>().HasData(
                    new Agent { Id = 1, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 2, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 3, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 4, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 5, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 6, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 7, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 8, Name = "Акционерное общество Новосибирскэнергосбыт" },
                    new Agent { Id = 9, Name = "Акционерное общество Новосибирскэнергосбыт" }
                    );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Sheetf> Sheetfs { get; set; }
        //public DbSet<Sheetf> Shablons { get; set; } = default!;
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<Role> Roles { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<SBDataLab> SBDataLabs { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SandSludgeMill> SandSludgeMills { get; set; } = default!;
        public DbSet<SandSludgePool> SandSludgePools { get; set; } = default!;
        public DbSet<IzvestFromSilos> IzvestFromSilos { get; set; } = default!;
        public DbSet<InputControlSand> InputControlSands { get; set; } = default!;
        public DbSet<InputControlIzvest> InputControlIzvests { get; set; } = default!;
        public DbSet<ResultsLimeMill> ResultsLimeMills { get; set; } = default!;
        public DbSet<ResultsPortlandCement> ResultsPortlandCements { get; set; } = default!;
        public DbSet<H_Factory> H_Factory { get; set; } = default!;
        public DbSet<H_Division> H_Division { get; set; } = default!;
        public DbSet<H_object> H_object { get; set; } = default!;
        public DbSet<H_eemp> H_eemp { get; set; } = default!;
        public DbSet<S_Factory_info> S_Factory_infos { get; set; } = default!;
        public DbSet<S_Division_info> S_Division_infos { get; set; } = default!;
        public DbSet<S_object_info> S_object_infos { get; set; } = default!;
        public DbSet<S_eemp_info> S_eemp_infos { get; set; } = default!;
        public DbSet<I_Factory_Division> I_Factory_Divisions { get; set; } = default!;
        public DbSet<I_division_object> I_division_objects { get; set; } = default!;
        public DbSet<I_object_eemp> I_object_eemps { get; set; } = default!;
        public DbSet<I_Division_eemp> I_Division_eemps { get; set; } = default!;
        public DbSet<I_Factory_eemp> I_Factory_eemps { get; set; } = default!;
        public DbSet<WebAppAutorization.Data.Tables.Resource> Resource { get; set; } = default!;


        //public DbSet<IzvestFromSilos> IzvestFromSiloss { get; set; } = default!;
        //public DbSet<SandSludgeMill> SandSludgeMills { get; set; } = default!;
        //public DbSet<SandySludgePool> SandySludgePools { get; set; } = default!;
    }
}