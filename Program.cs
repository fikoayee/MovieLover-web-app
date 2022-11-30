using Microsoft.EntityFrameworkCore;
using MovieLover.Data;
using MovieLover.Data.Services;
using MovieLover.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieLoverContext>();
builder.Services.AddDbContext<MovieLoverContext>(
 options => options.UseSqlite(builder.Configuration["Data:C:\\Users\\Fifi\\AppData\\Local\\MovieLover33.db"]));
builder.Services.AddScoped<IMovieService, MovieService>();
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

MovieLoverSeeder.Seed(app); // full fill database w data
app.Run();

