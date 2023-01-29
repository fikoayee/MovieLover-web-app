using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieLover.Data.Base;
using MovieLover.Data.ViewModels;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class MovieService : EntityBaseRepository<MovieModel>, IMovieService 
    {
        private readonly MovieLoverContext _context;
        public MovieService(MovieLoverContext context) : base(context) 
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(NewMovieVM movie)
        {
            var newMovie = new MovieModel()
            {
                Name = movie.Name,
                Description = movie.Description,
                ImageURL = movie.ImageURL,
                LengthHours = movie.LengthHours,
                LengthMinutes = movie.LengthMinutes,
                MovieCategory = movie.MovieCategory,
                Price = movie.Price,
                ProducerId = movie.ProducerId,
                ReleaseDate = movie.ReleaseDate,
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();

            foreach (var actorId in movie.ActorsId)
            {
                var newActorMovie = new ActorMovieModel()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await _context.ActorsMovies.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }



        public async Task<MovieModel> GetMovieByIdAsync(int id)
        {
            var movieDetails = _context.Movies.Include(p => p.Producer).Include(am => am.ActorsMovies).ThenInclude(a => a.Actor).FirstOrDefaultAsync(n => n.Id == id);
            return await movieDetails;
        }

        public async Task<MovieDropDownVM> GetMovieDropdownValues()
        {
            var dropdown = new MovieDropDownVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return dropdown;
        }


    }
}
