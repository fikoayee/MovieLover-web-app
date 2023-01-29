using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieLover.Data.Services;
using MovieLover.Data.Static;
using MovieLover.Data.ViewModels;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class MovieController : Controller
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        // Details for a movie
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);

            //if (movieDetails == null)
            //    return View("Empty");
            return View(movieDetails);
        }

        // Show all movies
        [AllowAnonymous]
        public async Task<IActionResult> Index() 
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> SearchMovie(string searchMovie)
        {
            var data = await _service.GetAllAsync();


            if (!string.IsNullOrEmpty(searchMovie))
            {
                var dataFiltered = data.Where(n => n.Name.IndexOf(searchMovie, StringComparison.OrdinalIgnoreCase) != -1);
                return View("Index", dataFiltered);
            }
            return View("Index", data);

        }


        // Add new movie
        public async Task<IActionResult> Create()
        {
            var dropdown = await _service.GetMovieDropdownValues();

            ViewBag.ProducerId = new SelectList(dropdown.Producers, "Id", "FullName");
            ViewBag.ActorId = new SelectList(dropdown.Actors, "Id", "FullName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(NewMovieVM movie)
        {
           if (!ModelState.IsValid)
            {
                var dropdown = await _service.GetMovieDropdownValues();
                ViewBag.ProducerId = new SelectList(dropdown.Producers, "Id", "FullName");
                ViewBag.ActorId = new SelectList(dropdown.Actors, "Id", "FullName");
                return View("Create");
            }
            await _service.AddNewMovieAsync(movie);
            return RedirectToAction("Index");
        }

        // Update movie
        public async Task<IActionResult> Update(int id)
        {
            var dropdown = await _service.GetMovieDropdownValues();
            ViewBag.ProducerId = new SelectList(dropdown.Producers, "Id", "FullName");

            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null)
                return View("Empty");
            return View(movieDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, MovieModel movie)
        {

            if (!ModelState.IsValid)
            {
                return View("Empty");
            }
            await _service.UpdateAsync(id, movie);
            return RedirectToAction("Index");
        }

        // Delete movie
        public async Task<IActionResult> Delete(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null)
                return View("Empty");
            return View(movieDetails);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null) return View("Empty");
          
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public async Task<IActionResult> SearchMovieByCategory(MovieCategory category)
        {
            var data = await _service.GetAllAsync();



            var dataFiltered = data.Where(n => n.MovieCategory == category);
            return View("Index", dataFiltered);

        }

    }
}
