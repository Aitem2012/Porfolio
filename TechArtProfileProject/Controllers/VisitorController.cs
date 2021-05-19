﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.ViewModels;

namespace TechArtProfileProject.Controllers
{
    public class VisitorController : Controller
    {
        private readonly ILogger<VisitorController> _logger;
        private readonly IUserProfileService _userProfileService;
        private readonly IProjectService _projectService;
        private readonly IEducationsService _educationService;
        private readonly IUserServicesService _userService;
        private readonly VisitorViewModel _visitor;

        public VisitorController(ILogger<VisitorController> logger, IUserProfileService userProfileService, 
            IProjectService projectService, IEducationsService educationService, IUserServicesService userServices)
        {
            _logger = logger;
            
            _userProfileService = userProfileService;
            _projectService = projectService;
            _educationService = educationService;
            _userService = userServices;
            _visitor = new VisitorViewModel();

        }
        public IActionResult Index()
        {
            var profile = _userProfileService.GetUserProfile(1);
            _visitor.UserProfile = _userProfileService.GetUserProfile(1);
            _visitor.GetProjects = _projectService.GetAllProjects(profile.UserId);
            _visitor.GetEducations = _educationService.GetAllEducation(profile.UserId);
            _visitor.GetUserServices = _userService.GetAllServices(profile.UserId);
            return View(_visitor);
        }
    }
}
