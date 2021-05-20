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

        private int _dummy { get; set; }

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
        public IActionResult Index(string Id)
        {
            var profile = _userProfileService.GetUserProfile(Id);
           
            _profile.UserProfile = _userProfileService.GetUserProfile(Id);
            
            _profile.GetProjects = _projectService.GetAllProjects(profile.Id);
            _profile.GetEducations = _educationService.GetAllEducation(profile.Id);
            _profile.GetUserServices = _userService.GetAllServices(profile.Id);
            return View(_profile);
        }

        public IActionResult Edit(string id)
        {
            var user = _userProfileService.GetUserProfile(id);
            _singleUser.FirstName = user.FirstName;
            _singleUser.LastName = user.LastName;
            _singleUser.Email = user.Email;
            _singleUser.Biography = user.Biography;
            _singleUser.Image = user.Image;
            _singleUser.JobTitle = user.JobTitle;
            _singleUser.UserProfileId = user.Id;
            _singleUser.UserId = user.UserId;
            return View(_singleUser);
        }

        [HttpPost]
        public IActionResult Edit(UserProfile userProfile)
        {
            var oldModel = _userProfileService.GetUserProfile(userProfile.Id);
            //userProfile.Id = oldModel.Id;
            _userProfileService.Update(userProfile);

            var myProfile =_userProfileService.GetUserProfile(userProfile.Id);

            var myUser = new UserProfileViewModel
            {
                FirstName = myProfile.FirstName,
                LastName = myProfile.LastName,
                Email = myProfile.Email,
                Biography = myProfile.Biography,
                Image = myProfile.Image,
                UserProfileId = myProfile.Id,
                UserId = myProfile.UserId,
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
                ServiceName = userServices.ServiceName,
                UserI = userServices.UserId
            };

            return View(service);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            var myService = _userService.CreateProject("", "");
            var service = new ServiceViewModel
            {
                ServiceDescription = myService.ServiceDescription,
                ServiceId = myService.ServiceId,
                
                ServiceName = myService.ServiceName,
                UserI = myService.UserId
            };

            return View(service);

            
        }

        [HttpPost]
        public IActionResult AddService(ServiceViewModel model, string id)
        {
            
            var user = _userProfileService.GetUserProfile(model.UserId);
            var service = new ServiceViewModel
            {
                ServiceDescription = model.ServiceDescription,
                ServiceId = model.ServiceId,
                UserId = user.Id,
                ServiceName = model.ServiceName,
                
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
            _projectViewModel.UserId = project.UserId;
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
            _projectViewModel.UserId = projec.UserId;
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
            _educationViewModel.UserId = education.UserId;
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
            _educationViewModel.UserId = edu.UserId;
            return View(_educationViewModel);
        }
    }
}
