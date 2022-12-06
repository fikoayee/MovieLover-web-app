using Microsoft.EntityFrameworkCore;
using MovieLover.Data;
using MovieLover.Models;
using System;
using System.Collections.Generic;

public class MovieLoverContext : DbContext
{
    public DbSet<RegisterModel> Registers { get; set; }
    public DbSet<MovieModel> Movies { get; set; }
    public DbSet<ActorModel> Actors { get; set; }
    public DbSet<ProducerModel> Producers { get; set; }
    public DbSet<ActorMovieModel> ActorsMovies { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = C:\\Users\\Fifi\\AppData\\Local\\MovieLover33.db"); // my path: C:\Users\Fifi\AppData\Local\MovieLover.db
    }
    public MovieLoverContext(DbContextOptions<MovieLoverContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActorMovieModel>().HasKey(am => new
        {
            am.ActorId,
            am.MovieId
        });

        modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Movie).WithMany(am => am.ActorsMovies).HasForeignKey(m => m.MovieId);
        modelBuilder.Entity<ActorMovieModel>().HasOne(m => m.Actor).WithMany(am => am.ActorsMovies).HasForeignKey(m => m.ActorId);



        base.OnModelCreating(modelBuilder);
    }


}

