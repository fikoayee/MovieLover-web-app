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
                        ImageURL = "https://static.wikia.nocookie.net/shrek/images/8/85/Shrek_2001_poster.jpg/revision/latest?cb=20201020072731"
                        },
                        new MovieModel()
                        {
                            Name = "Shrek 2",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek 2 Shrek 2 Shrek 2",
                            ReleaseDate = new DateTime(2004, 05, 19),
                            Price = 6.99,
                            ImageURL = "https://static.wikia.nocookie.net/dreamworks-polska/images/f/ff/Shrek_2.jpg/revision/latest?cb=20170212075406&path-prefix=pl"
                        },
                        new MovieModel()
                        {
                            Name = "Shrek the Third",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek the Third Shrek the Third Shrek the Third",
                            ReleaseDate = new DateTime(2007, 05, 18),
                            Price = 7.99,
                            ImageURL = "https://m.media-amazon.com/images/I/7113rtP6ruL.jpg"
                        },
                        new MovieModel()
                        {
                            Name = "Shrek Forever After",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek Forever After Shrek Forever After Shrek Forever After",
                            ReleaseDate = new DateTime(2010, 05, 21),
                            Price = 8.99,
                            ImageURL = "https://ecsmedia.pl/c/shrek-forever-after-b-iext47705115.jpg"
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
