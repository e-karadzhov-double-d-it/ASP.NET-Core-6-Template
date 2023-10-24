using Data;
using Microsoft.EntityFrameworkCore;
using Service.Automapper;
using Service.Service.User;
using System.Reflection;
using Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Database Services
var configurations = builder.Configuration["ConnectionStrings:DefaultConnection"];

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configurations));

builder.Services.AddSession();


// Add services to the container.
builder.Services.AddControllersWithViews();


// Services
AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

builder.Services.AddTransient<IUserService, UserService>();


var app = builder.Build();

// Seed data on application startup
using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
