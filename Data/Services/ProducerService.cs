using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieLover.Data.Base;
using MovieLover.Models;

namespace MovieLover.Data.Services
{
    public class ProducerService : EntityBaseRepository<ProducerModel>, IProducerService 
    {
        public ProducerService(MovieLoverContext context) : base(context) { }
    }
}
