using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieLoverContext _context;
        public MovieService(MovieLoverContext context)
        {
            _context = context;
        }

        public async Task AddAsync(MovieModel movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task <IEnumerable<MovieModel>> GetAllAsync()
        {
            var result = _context.Movies.ToList();
            return result;
        }

        public async Task<MovieModel> GetByIdAsync(int id)
        {
            var result = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            return result;
        }

        public async Task<MovieModel> UpdateAsync(int id, MovieModel newMovie)
        {
            _context.Movies.Update(newMovie);
            await _context.SaveChangesAsync();
            return newMovie;
        }

        public async Task DeleteAsync(int id)
        {
            var result = _context.Movies.FirstOrDefault(m => m.Id == id);
            _context.Movies.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
