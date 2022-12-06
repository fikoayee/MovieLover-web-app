using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieModel>> GetAllAsync();
        Task<MovieModel> GetByIdAsync(int id);
        Task AddAsync(MovieModel movie);
        Task<MovieModel> UpdateAsync(int id, MovieModel movie);
        Task DeleteAsync(int id);




    }
}
