using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieLover.Data.Base;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class MovieService : EntityBaseRepository<MovieModel>, IMovieService 
    {
        public MovieService(MovieLoverContext context) : base(context) { }
    }
}
