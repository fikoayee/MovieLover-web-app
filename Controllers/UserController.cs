using Microsoft.AspNetCore.Mvc;
using MovieLover.Models;

namespace MovieLover.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(RegisterModel register)
        {
            using (var db = new MovieLoverContext())
            {
                db.Add(register);
                db.SaveChanges();
            };
            return View();
        }

    }
}
