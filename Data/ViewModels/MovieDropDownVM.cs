using MovieLover.Models;

namespace MovieLover.Data.ViewModels
{
    public class MovieDropDownVM
    {
        public MovieDropDownVM()
        {
            Producers = new List<ProducerModel>();
            Actors = new List<ActorModel>();
        }
        public List<ProducerModel> Producers { get; set; }
        public List<ActorModel> Actors { get; set; }
    }
}

