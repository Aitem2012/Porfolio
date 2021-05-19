using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Models;
using TechArtProfileProject.ViewModels;

namespace TechArtProfileProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserProfileService _userProfileService;
        private readonly AllUserProfileViewModel _allUserViewModel;

        public HomeController(ILogger<HomeController> logger, IUserProfileService userProfileService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
            _allUserViewModel = new AllUserProfileViewModel();
        }

        public IActionResult Index()
        {
            
            _allUserViewModel.Profiles =  _userProfileService.GetAllUserProfiles();
            return View(_allUserViewModel);
        }


        public IActionResult Dummydashboard()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
