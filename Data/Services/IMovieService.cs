using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public interface IMovieService
    {
        IEnumerable<MovieModel> GetAll();
        MovieModel GetById(int id);
        void Add(MovieModel movie);




    }
}
