using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models;
using TechArtProfileProject.ViewModels;

namespace TechArtProfileProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly AllUserProfileViewModel _profile;
        private readonly UserProfileViewModel _singleUser;
        private readonly IUserProfileService _userProfileService;
        private readonly IProjectService _projectService;
        private readonly IEducationsService _educationService;
        private readonly IUserServicesService _userService;
        private readonly ServiceViewModel _serviceViewModel;
        private readonly EditProjectViewModel _projectViewModel;
        private readonly EducationViewModel _educationViewModel;

        public DashboardController(ILogger<DashboardController> logger, IUserProfileService userProfileService, 
            IProjectService projectService, IEducationsService educationService, IUserServicesService userServices)
        {
            _logger = logger;
            _profile = new AllUserProfileViewModel();
            _singleUser = new UserProfileViewModel();
            _userProfileService = userProfileService;
            _projectService = projectService;
            _educationService = educationService;
            _userService = userServices;
            _serviceViewModel = new ServiceViewModel();
            _projectViewModel = new EditProjectViewModel();
            _educationViewModel = new EducationViewModel();
        }
        //[Authorize]
        [HttpGet]
        public IActionResult Index(int Id)
        {
            var profile = _userProfileService.GetUserProfile(Id);
            _profile.UserProfile = _userProfileService.GetUserProfile(Id);
            _profile.GetProjects = _projectService.GetAllProjects(profile.UserId);
            _profile.GetEducations = _educationService.GetAllEducation(profile.UserId);
            _profile.GetUserServices = _userService.GetAllServices(profile.UserId);
            return View(_profile);
        }

        public IActionResult Edit(int id)
        {
            var user = _userProfileService.GetUserProfile(id);
            _singleUser.FirstName = user.FirstName;
            _singleUser.LastName = user.LastName;
            _singleUser.Email = user.Email;
            _singleUser.Biography = user.Biography;
            _singleUser.Image = user.Image;
            _singleUser.JobTitle = user.JobTitle;
            _singleUser.UserProfileId = user.UserId;
            return View(_singleUser);
        }

        [HttpPost]
        public IActionResult Edit(UserProfile userProfile, int id)
        {
            var oldModel = _userProfileService.GetUserProfile(userProfile.UserId);
            
            _userProfileService.Update(userProfile);

            var myProfile =_userProfileService.GetUserProfile(userProfile.UserId);

            var myUser = new UserProfileViewModel
            {
                FirstName = myProfile.FirstName,
                LastName = myProfile.LastName,
                Email = myProfile.Email,
                Biography = myProfile.Biography,
                Image = myProfile.Image,
                //UserProfileId = myProfile.UserProfileId,
                JobTitle = myProfile.JobTitle                
            };

            return View(myUser);
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var userServices = _userService.GetUserService(id);

            var service = new ServiceViewModel
            {
                ServiceDescription = userServices.ServiceDescription,
                ServiceId = userServices.ServiceId,
                UserId = userServices.UserProfileId,
                ServiceName = userServices.ServiceName
            };

            return View(service);
        }
        [HttpPost]
        public IActionResult EditService(UserServices userService, int id)
         {
            var userServices = _userService.GetUserService(userService.ServiceId);
            userService.UserProfileId = userServices.UserProfileId;

            _userService.Update(userService);
            var service = new ServiceViewModel
            {
                ServiceDescription = userService.ServiceDescription,
                ServiceId = userService.ServiceId,
                UserId = userService.UserProfileId,
                ServiceName = userService.ServiceName
            };

            return View(service);
        }

        public IActionResult EditProject(int id)
        {
            var project = _projectService.GetProject(id);
            _projectViewModel.ProjectId = project.ProjectId;
            _projectViewModel.ProjectName = project.ProjectName;
            _projectViewModel.ProjectDescription = project.ProjectDescription;
            _projectViewModel.ProjectLink = project.ProjectLink;
            _projectViewModel.UserProfileId = project.UserProfileId;
            return View(_projectViewModel);
        }

        [HttpPost]
        public IActionResult EditProject(Project project, int id)
        {
            var myProject = _projectService.GetProject(id);
            project.UserProfile = myProject.UserProfile;

            _projectService.Update(project);

            var projec = _projectService.GetProject(project.ProjectId);
            _projectViewModel.ProjectId = projec.ProjectId;
            _projectViewModel.ProjectName = projec.ProjectName;
            _projectViewModel.ProjectDescription = projec.ProjectDescription;
            _projectViewModel.ProjectLink = projec.ProjectLink;
            _projectViewModel.UserProfileId = projec.UserProfileId;
            return View(_projectViewModel);
        }

        public IActionResult EditEducation(int id)
        {
            var education = _educationService.GetEducation(id);
            _educationViewModel.EducationId = education.EducationId;
            _educationViewModel.Discipline = education.Discipline;
            _educationViewModel.DegreeObtained = education.DegreeObtained;
            _educationViewModel.StartDate = education.StartDate;
            _educationViewModel.GraduationDate = education.GraduationDate;
            _educationViewModel.SchoolName = education.SchoolName;
            _educationViewModel.UserProfileId = education.UserProfileId;
            return View(_educationViewModel);
        }

        [HttpPost]
        public IActionResult EditEducation(Education education, int id)
        {
            var educations = _educationService.GetEducation(id);
            education.UserProfile = educations.UserProfile;

            _educationService.Update(education);

            var edu = _educationService.GetEducation(education.EducationId);
            _educationViewModel.EducationId = edu.EducationId;
            _educationViewModel.Discipline = edu.Discipline;
            _educationViewModel.DegreeObtained = edu.DegreeObtained;
            _educationViewModel.StartDate = edu.StartDate;
            _educationViewModel.GraduationDate = edu.GraduationDate;
            _educationViewModel.SchoolName = edu.SchoolName;
            _educationViewModel.UserProfileId = edu.UserProfileId;

            return View(_educationViewModel);
        }
    }
}
