using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;

        public ProducerController(IProducerService service)
        {
            _service = service;
        }
        
        // Details for a movie
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
                return View("Empty");
            return View(producerDetails);
        }

        // Show all movies
        public async Task<IActionResult> Index() 
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        // Add new movie
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(ProducerModel producer)
        {
           if (!ModelState.IsValid)
            {
                return View("Create");
            }
            await _service.AddAsync(producer);
            return RedirectToAction("Index");
        }

        // Update movie
        public async Task<IActionResult> Update(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null)
                return View("Empty");
            return View(movieDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, ProducerModel producer)
        {
            if (!ModelState.IsValid)
            {
                return View("Empty");
            }
            await _service.UpdateAsync(id, producer);
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



    }
}
