using Microsoft.EntityFrameworkCore;
using MovieLover.Data;
using MovieLover.Models;
using System;
using System.Collections.Generic;

public class MovieLoverContext : DbContext
{
    public string DbPath { get; }
    public DbSet<RegisterModel> Registers { get; set; }
    public DbSet<MovieModel> Movies { get; set; }




    public MovieLoverContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "MovieLoverDB.db"); // my path: C:\Users\Fifi\AppData\Local
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

