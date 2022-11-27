using Microsoft.AspNetCore.Mvc;

namespace MovieLover.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var db = new MovieLoverContext();
            var data = db.Movies.ToList();
            return View(data);
        }
    }
}
