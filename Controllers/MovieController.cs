using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MovieModel movie)
        {
           if (!ModelState.IsValid)
            {
                return View("Create");
            }
            _service.Add(movie);
            return RedirectToAction("Index");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = _service.GetById(id);
            if (movieDetails == null)
                return View("Empty");
            return View(movieDetails);
        }
    }
}
