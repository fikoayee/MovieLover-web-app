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

        public void Add(MovieModel movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovieModel> GetAll()
        {
            var result = _context.Movies.ToList();
            return result;
        }

        public MovieModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MovieModel Update(int id, MovieModel newMovie)
        {
            throw new NotImplementedException();
        }
    }
}
