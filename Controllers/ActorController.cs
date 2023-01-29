using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieLover.Data.Services;
using MovieLover.Data.Static;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ActorController : Controller
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }

        // Details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null)
                return View("Empty");
            return View(actorDetails);

        }

        // Show all 
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
        public async Task<IActionResult> AddAsync(ActorModel actor)
        {
           if (!ModelState.IsValid)
            {
                return View("Create");
            }
            await _service.AddAsync(actor);
            return RedirectToAction("Index");
        }

        // Update 
        public async Task<IActionResult> Update(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("Index");
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsync(int id, ActorModel actor)
        {
            if (!ModelState.IsValid)
            {
                return View("Update");
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction("Index");
        }

        // Delete 
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
