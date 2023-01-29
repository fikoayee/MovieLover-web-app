using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Data.Static;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;

        public ProducerController(IProducerService service)
        {
            _service = service;
        }

        // Details 
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);

            if (producerDetails == null)
                return View("Empty");
            return View(producerDetails);
        }

        // Show all movies
        [AllowAnonymous]
        public async Task<IActionResult> Index() 
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        // Add new 
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

        // Update
        public async Task<IActionResult> Update(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null)
                return View("Index");
            return View(movieDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, ProducerModel producer)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction("Index");
        }

        // Delete 
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
