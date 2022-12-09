using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieLover.Data.Base;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class ActorService : EntityBaseRepository<ActorModel>, IActorService 
    {
        public ActorService(MovieLoverContext context) : base(context) { }
    }
}
