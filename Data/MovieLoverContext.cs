using Microsoft.EntityFrameworkCore;
using MovieLover.Data;
using MovieLover.Models;
using System;
using System.Collections.Generic;

public class MovieLoverContext : DbContext
{
    public DbSet<RegisterModel> Registers { get; set; }
    public DbSet<MovieModel> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = C:\\Users\\Fifi\\AppData\\Local\\MovieLover33.db"); // my path: C:\Users\Fifi\AppData\Local\MovieLover.db
    }
    public MovieLoverContext(DbContextOptions<MovieLoverContext> options) : base(options) { }
}

