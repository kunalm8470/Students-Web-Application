using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Students.Domain.Interfaces.Repository;
using Students.Infrastructure.Database;
using Students.Infrastructure.Database.Repository;
using Students.Web;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(
    connectionString
    //options => options.MigrationsAssembly(typeof(SchoolDbContext).Assembly.FullName)
    )
);

// For Hot reload in .NET 6 MVC projects
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfile());
}).CreateMapper());

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Students}/{action=Index}/{id?}");

app.Run();
