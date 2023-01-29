using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieLover.Data.Services;
using MovieLover.Data.Static;
using MovieLover.Data.ViewModels;
using MovieLover.Models;

namespace movielover.controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        private readonly MovieLoverContext _context;

   
        public UserController(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, MovieLoverContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        // ------------ LOG IN -------------------
        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
                return View(login);
            
            var user = await _userManager.FindByEmailAsync(login.Email);
            if (user != null)
            {
                var password = await _userManager.CheckPasswordAsync(user, login.Password);
                if (password)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movie");
                    }
                }
                TempData["ErrorLogin"] = "Incorrect username or/and password.";
                return View(login);
            }
            TempData["ErrorLogin"] = "Incorrect username or/and password.";
            return View(login);
        }

        // ------------ REGISTER -------------------
        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
                return View(register);

            var user = await _userManager.FindByEmailAsync(register.Email);
            if (user != null)
            {
                TempData["ErrorMail"] = "This email is already in use";
                return View(register);
            }
            
            var newUser = new UserModel()
            {
                
                FullName = register.FullName,
                UserName = Username(register.Email),
                Email = register.Email,
            };
            var newUserCreate = await _userManager.CreateAsync(newUser, register.Password);

            if (newUserCreate.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            }
            return View("RegisterCompleted");
        }

        public string Username(string fullName)
        {
            string[] fullNameSplit = fullName.Split('@');
            return fullNameSplit[0];
        }

        // ------------ LOG OUT -------------------

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movie");
        }

        // Admin page to show all users
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> UserListAll()
        {

            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // ---------- ACCESS DENIED --------
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
    }
}
