using E_Books.Data;
using E_Books.Data.Static;
using E_Books.Data.ViewModels;
using E_Books.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Books.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;
        public AccountsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Books");
                    }
                }
                else
                {
                    TempData["Error"] = "Wrong Credintials...";
                    return View(loginVM);
                }
            }
            TempData["Error"] = "Wrong credintals try again...!";
            return View(loginVM);
        }

        public IActionResult Signup()
        {
            return View(new SignupVM());
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupVM signupVM)
        {
            if (!ModelState.IsValid)
                return View(signupVM);

            var existingUser = await _userManager.FindByEmailAsync(signupVM.EmailAddress);
            if (existingUser != null)
            {
                TempData["Error"] = "Email already in use!";
                return View(signupVM);
            }

            var newUser = new AppUser()
            {
                FullName = signupVM.FullName,
                Email = signupVM.EmailAddress,
                UserName = signupVM.EmailAddress
            };

            var newResponse = await _userManager.CreateAsync(newUser, signupVM.Password);

            if (newResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Books");
        }

        public async Task<IActionResult> Details()
        {
            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);
            if (loggedInUser is null)
                return View("NotFound");

            SignupVM thisUser = new SignupVM()
            {
                FullName = loggedInUser.FullName,
                EmailAddress = loggedInUser.Email,
            };

            return View(thisUser);
        }

        public async Task<IActionResult> getAllUsers()
        {
            var allUsers = await _userManager.Users.ToListAsync();
            return View(allUsers);
        }
    }
}
