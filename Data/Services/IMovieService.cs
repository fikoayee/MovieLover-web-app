using MovieLover.Data.Base;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<MovieModel>
    {
    }
}
