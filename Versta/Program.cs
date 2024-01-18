using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.EntityFrameworkCore;
using Versta.Data;
using Versta.Data.Interfaces;
using Versta.Data.Models;
using Versta.Data.Repo;
using Versta.Data.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);


// Add services to the container.
services.AddControllersWithViews();
services.AddRazorPages();
services.AddServerSideBlazor();
services.AddMvc();
services.AddRazorPages();
services.AddScoped<IRepo<Order>, Repo<Order>>();
services.AddScoped<IOrderService, OrderService>();


services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql("Host=localhost; Database=Versta; Username=postgres; Password=MyPassword;"),
    ServiceLifetime.Transient
);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
