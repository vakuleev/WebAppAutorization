using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Web.Optimization;
using AutoMapper;
using WebAppAutorization.Data;
using WebAppAutorization.Data.Identity;
using WebAppAutorization.Services.Email;
using FluentValidation.AspNetCore;
//using Microsoft.Win32;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

//System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
//Registry.SetValue(@"\HKEY_USERS\.DEFAULT\Control Panel\International", "sDecimal", ".", RegistryValueKind.String);

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container. -------------  MVC ----------------- E N A B L E !
//builder.Services.AddControllersWithViews();

//public gnsDbContext(DbContextOptions<gnsDbContext> options, IConfiguration configuration)
//            : base(options)

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw 
    new InvalidOperationException("Строка подключения «DefaultConnection» не найдена.");
builder.Services.AddDbContext<gnsDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<ApplicationIdentityUser>().AddDefaultTokenProviders()
//builder.Services.AddDefaultIdentity<ApplicationIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<WebAppAutorization.Data.gnsDbContext>(),;
builder.Services.AddDefaultIdentity<User>(options => {
    options.SignIn.RequireConfirmedAccount = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<gnsDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Понижение требований к паролю
    // Default Password settings.
    options.Password.RequiredLength = 3;               // минимальная длина
    //options.Password.RequiredUniqueChars  = 1;        
    options.Password.RequireLowercase       = false;   // требуются ли символы в нижнем регистре
    options.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
    options.Password.RequireUppercase       = false;   // требуются ли символы в верхнем регистре
    options.Password.RequireDigit           = false;   // требуются ли цифры
});

//[Authorize(Policy = "Administrators")]
//[Authorize(Policy = "Managers")]
//[Authorize(Policy = "Operators")]
//[Authorize(Policy = "Счета-фактуры")]
//[Authorize(Policy = "Ордера")]
//[Authorize(Policy = "Шаблоны ЭЭ")]
//[Authorize(Policy = "Продукт")]
//[Authorize(Policy = "Пользователь-Компании")]
//Шаблоны
//
// Заранее созданные политики права(роли) (страницы доступа к данным) пользователей
builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("Administrators", policy => policy.RequireRole("Admin"));
    opt.AddPolicy("Managers", policy => policy.RequireRole("Admin", "Manager"));
    opt.AddPolicy("Operators", policy => policy.RequireRole("Admin", "Manager", "Operator"));
    opt.AddPolicy("Документы ЭР", policy => policy.RequireRole("Admin", "Manager", "Operator", "Документы ЭР"));
    opt.AddPolicy("Ордера", policy => policy.RequireRole("Admin", "Manager", "Operator", "Ордера"));
    opt.AddPolicy("Ресурсы", policy => policy.RequireRole("Admin", "Manager", "Ресурсы"));
    opt.AddPolicy("Продукт", policy => policy.RequireRole("Admin", "Manager", "Продукт"));
    opt.AddPolicy("Операционный контроль", policy => policy.RequireRole("Admin", "Manager", "Операционный контроль"));
    opt.AddPolicy("Пользователь-Компании", policy => policy.RequireRole("Admin", "Manager", "Пользователь-Компании"));
    opt.AddPolicy("Компании", policy => policy.RequireRole("Admin", "Manager", "Компании"));
    opt.AddPolicy("Агенты", policy => policy.RequireRole("Admin", "Manager", "Агенты"));
    opt.AddPolicy("Шаблоны", policy => policy.RequireRole("Admin", "Manager", "Шаблоны"));
    opt.AddPolicy("Входной контроль песка", policy => policy.RequireRole("Admin", "Manager", "Входной контроль песка"));
    opt.AddPolicy("Входной контроль извести", policy => policy.RequireRole("Admin", "Manager", "Входной контроль извести"));
    opt.AddPolicy("Результаты испытаний молотой извести с мельницы", policy => policy.RequireRole("Admin", "Manager", "Результаты испытаний молотой извести с мельницы"));
    opt.AddPolicy("Результаты испытаний портландцемента", policy => policy.RequireRole("Admin", "Manager", "Результаты испытаний портландцемента"));
    opt.AddPolicy("Известь из силоса", policy => policy.RequireRole("Admin", "Manager", "Известь из силоса"));
    opt.AddPolicy("Песчаный шлам в шламбассейнах", policy => policy.RequireRole("Admin", "Manager", "Песчаный шлам в шламбассейнах"));
    opt.AddPolicy("Песчаный шлам с мельницы", policy => policy.RequireRole("Admin", "Manager", "Песчаный шлам с мельницы"));
    opt.AddPolicy("Операционный контроль сырья", policy => policy.RequireRole("Admin", "Manager", "Операционный контроль сырья"));

    opt.AddPolicy("ХАБ Фабрики", policy => policy.RequireRole("Admin", "Manager", "ХАБ Фабрики"));
    opt.AddPolicy("ХАБ Дивизионы", policy => policy.RequireRole("Admin", "Manager", "ХАБ Дивизионы"));
    opt.AddPolicy("ХАБ Объекты", policy => policy.RequireRole("Admin", "Manager", "ХАБ Объекты"));
    opt.AddPolicy("ХАБ Метрологии", policy => policy.RequireRole("Admin", "Manager", "ХАБ Метрологии"));

    opt.AddPolicy("Доп инфо компании", policy => policy.RequireRole("Admin", "Manager", "Доп инфо компанииДоп инфо компании"));
});

//TODO ---------------- Доработать внешний сервис для подтверждения Email --------------------//
//builder.Services.AddTransient<IEmailSender, EmailSender>();
//TODO ---------------- Доработать внешний сервис для подтверждения Email --------------------//

builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

//builder.Services.AddFluentValidation(ce => );

//builder.Services.AddFluentValidationAutoValidation(config =>
//{
//    config.ImplicitlyValidateChildProperties = true;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
//app.UseRouting();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

//// Add services to the container. -------------  MVC ----------------- E N A B L E !
////app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(name: "mvc", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
