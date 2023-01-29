using MovieLover.Data.Base;
using MovieLover.Data.ViewModels;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<MovieModel>
    {
        Task<MovieModel> GetMovieByIdAsync(int id);
        Task<MovieDropDownVM> GetMovieDropdownValues();
        Task AddNewMovieAsync(NewMovieVM movie);
    }
}
