using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Models;
using TechArtProfileProject.ViewModels;

namespace TechArtProfileProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<UserProfile> _signInManager;
        private readonly IUserProfileService _userService;
        private readonly UserManager<UserProfile> _userManager;

        public AccountController(ILogger<AccountController> logger, SignInManager<UserProfile> signInManager, IUserProfileService userService, UserManager<UserProfile> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userService = userService;
            _userManager = userManager;
        }
        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userFound = await _userManager.FindByEmailAsync(model.Username);
                if (userFound == null)
                {
                    ModelState.AddModelError("", "Invalid Credentials");
                    return View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password,
                    false, false);
               
                if (result.Succeeded)
                {
                   
                        return RedirectToAction("Index", "Dashboard", new 
                        {
                            id = userFound.Id
                        }
                        );
                    
                }
            }
            ModelState.AddModelError("", "Failed to login");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View(model);
            }
            var profile = new UserProfile
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email
            };
            var userFound = await _userManager.FindByEmailAsync(model.Email);
            if (userFound != null)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }
            var result = await _userManager.CreateAsync(profile, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View(model);
                }
            }
            return RedirectToAction("Login");

            
        }
    }
}
