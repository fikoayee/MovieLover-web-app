using MovieLover.Models;

namespace MovieLover.Data
{
    public class MovieLoverSeeder
    {
        public static void Seed()
        {
            using (var context = new MovieLoverContext())
            {
                context.Database.EnsureCreated();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {   new MovieModel()
                        {
                        Name = "Shrek",
                        MovieCategory = MovieCategory.ForKids,
                        Description = "Shrek Shrek Shrek Shrek",
                        ReleaseDate = new DateTime(2001, 05, 18),
                        Price = 3.99,
                        },
                        new MovieModel()
                        {
                            Name = "Shrek 2",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek 2 Shrek 2 Shrek 2",
                            ReleaseDate = new DateTime(2004, 05, 19),
                            Price = 6.99,
                        },
                        new MovieModel()
                        {
                            Name = "Shrek the Third",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek the Third Shrek the Third Shrek the Third",
                            ReleaseDate = new DateTime(2007, 05, 18),
                            Price = 7.99,
                        },
                        new MovieModel()
                        {
                            Name = "Shrek Forever After",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek Forever After Shrek Forever After Shrek Forever After",
                            ReleaseDate = new DateTime(2010, 05, 21),
                            Price = 8.99,
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
