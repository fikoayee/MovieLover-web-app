using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }
        
        // Details for a movie
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
                return View("Empty");
            return View(actorDetails);
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
        public async Task<IActionResult> AddAsync(ActorModel actor)
        {
           if (!ModelState.IsValid)
            {
                return View("Create");
            }
            await _service.AddAsync(actor);
            return RedirectToAction("Index");
        }

        // Update movie
        public async Task<IActionResult> Update(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("Empty");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, ActorModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View("Empty");
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction("Index");
        }

        // Delete movie
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("Empty");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
          
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }



    }
}
