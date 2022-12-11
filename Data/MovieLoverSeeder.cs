using Microsoft.AspNetCore.Identity;
using MovieLover.Data.Static;
using MovieLover.Models;

namespace MovieLover.Data
{
    public class MovieLoverSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MovieLoverContext>();
                context.Database.EnsureCreated();


                //actors&movies
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            
                            FullName = "Mike Myers",
                            DateOfBirth = new DateTime(1963, 05, 25),
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTY0MTM1MTM5Nl5BMl5BanBnXkFtZTcwNzA1OTM3MQ@@._V1_UY1200_CR82,0,630,1200_AL_.jpg",
                            Biography = "Michael John Myers was born in 1963 in Scarborough, Ontario, to Alice E. (Hind), an officer supervisor, and Eric Myers, an insurance agent. His parents were both English, and had served in the Royal Air Force and British Army, respectively.Myers' television career really started in 1988, when he joined Saturday Night Live (1975), where he spent six seasons. He brought to life many memorable characters, such as Dieter and Wayne Cambell. His major movies include Wayne's World (1992), Wayne's World 2 (1993), So I Married an Axe Murderer (1993), the Austin Powers movies and The Cat in the Hat (2003).",
                            PlaceOfBirthCity = "Scarborough",
                            PlaceOfBirthCountry = "Canada",

                        }
                    });
                    context.SaveChanges();
                }

                // producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducerModel>()
                    {
                        new ProducerModel()
                        {
                            FullName = "Steven Spielberg",
                            DateOfBirth = new DateTime(1946, 12, 18),
                            Biography = "One of the most influential personalities in the history of cinema, Steven Spielberg is Hollywood's best known director and one of the wealthiest filmmakers in the world. He has an extraordinary number of commercially successful and critically acclaimed credits to his name, either as a director, producer or writer since launching the summer blockbuster with Jaws (1975), and he has done more to define popular film-making since the mid-1970s than anyone else.",
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMTY1NjAzNzE1MV5BMl5BanBnXkFtZTYwNTk0ODc0._V1_.jpg",
                            PlaceOfBirthCity = "Cincinnati, Ohio",
                            PlaceOfBirthCountry = "United States"
                        }
                    });
                    context.SaveChanges();
                }

                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        new MovieModel()
                        {
                        Name = "Shrek",
                        MovieCategory = MovieCategory.ForKids,
                        Description = "Shrek Shrek Shrek Shrek",
                        ReleaseDate = new DateTime(2001, 05, 18),
                        Price = 3.99,
                        ImageURL = "https://i-viaplay-com.akamaized.net/viaplay-prod/993/800/1613762117-f07774c22a81b35740522f9e1b18e1e03331bc19.jpg?width=400&height=600",
                        ProducerId = 1,

                        },
                        new MovieModel()
                        {
                            Name = "Shrek 2",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek 2 Shrek 2 Shrek 2",
                            ReleaseDate = new DateTime(2004, 05, 19),
                            Price = 6.99,
                            ImageURL = "https://a.allegroimg.com/original/11226c/61dac14a45ecb4cff63540b7ad16/SHREK-2-DVD",
                            ProducerId = 1,


                        },
                        new MovieModel()
                        {
                            Name = "Shrek the Third",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek the Third Shrek the Third Shrek the Third",
                            ReleaseDate = new DateTime(2007, 05, 18),
                            Price = 7.99,
                            ImageURL = "https://m.media-amazon.com/images/I/7113rtP6ruL.jpg",
                            ProducerId = 1,
                        },
                        new MovieModel()
                        {
                            Name = "Shrek Forever After",
                            MovieCategory = MovieCategory.ForKids,
                            Description = "Shrek Forever After Shrek Forever After Shrek Forever After",
                            ReleaseDate = new DateTime(2010, 05, 21),
                            Price = 8.99,
                            ImageURL = "https://ecsmedia.pl/c/shrek-forever-after-b-iext47705115.jpg",
                            ProducerId = 1,

                        }
                    });
                    context.SaveChanges();
                }

                //actors&movies
                if (!context.ActorsMovies.Any())
                {
                    context.ActorsMovies.AddRange(new List<ActorMovieModel>()
                    {
                        new ActorMovieModel()
                        {
                            ActorId = 1,
                            MovieId = 1
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
               
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Admins
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<UserModel>>();
                var adminUser = await userManager.FindByEmailAsync("admin@mlover.com");
                if (adminUser == null)
                {
                    var newAdminUser = new UserModel()
                    {
                        FullName = "Admin User",
                        UserName = "admin",
                        Email = "admin@mlover.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Sddldz123!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                //Users

                var user = await userManager.FindByEmailAsync("fdziubek@gmail.com");
                if (user == null)
                {
                    var newUser = new UserModel()
                    {
                        FullName = "Filip Dziubek",
                        UserName = "fifi",
                        Email = "fdziubek@gmail.com",
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newUser, "Sddldz123!");
                    await userManager.AddToRoleAsync(newUser, UserRoles.User);
                }
            }
        }
    }
}
