using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieLover.Data;
using MovieLover.Data.Services;
using MovieLover.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MovieLoverContext>(
 options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<IActorService, ActorService>();

// Authentication & Authorization
builder.Services.AddIdentity<UserModel, IdentityRole>().AddEntityFrameworkStores<MovieLoverContext>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});


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
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

MovieLoverSeeder.Seed(app); // full fill database w data for movies
MovieLoverSeeder.SeedUsersAndRolesAsync(app); // full fill database w data for admins/users/roles
app.Run();

