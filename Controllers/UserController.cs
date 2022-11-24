using Microsoft.AspNetCore.Mvc;
using MovieLover.Models;
using System.Reflection.Emit;

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
            if (ModelState.IsValid)
            {
                using (var db = new MovieLoverContext())
                {
                    db.Add(register);
                    db.SaveChanges();
                    return View("Views/User/RegisterCompleted.cshtml");
                }
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public ActionResult VerifyPassword(LoginModel user)
        {
            //The ".FirstOrDefault()" method will return either the first matched
            //result or null
            var db = new MovieLoverContext();

            var myUser = db.Registers
                .FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            if (myUser != null)
            {
                return View("Views/Home/Index.cshtml");
            }
            else
            {
                ViewData["LoginError"] = "Invalid username or/and password!";
                return View("Views/User/Login.cshtml");

            }

        }

    }
}
