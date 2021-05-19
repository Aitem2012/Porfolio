using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Model.Models;
using TechArtProfileProject.Models;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject.Lib.Infrastructure
{
    public class UserProfileDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserServices> Services { get; set; }
        public DbSet<Education> Educations { get; set; }



        public UserProfileDbContext(DbContextOptions<UserProfileDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserProfile>().HasData(SeedUserProfile());

            

            modelBuilder.Entity<Project>().HasData(new[] {
            new Project()
                {
                    ProjectId = 1,
                    ProjectDescription ="Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    ProjectName ="Bank App",
                    UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d",
                    UserId =1

                },
                new Project()
                {
                    ProjectId = 2,
                    ProjectName = "MVC",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d",
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                    UserId =1
                },
                new Project()
                {
                    ProjectId = 3,
                    ProjectName = "Fire Alarm",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289",
                    UserId =2,
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 4,
                    ProjectName = "Mobile SMS Sender",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    UserProfileId ="2438b126-7410-43dc-84f8-f5e6c5c71289",
                    UserId =2,
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 5,
                    ProjectName = "Intruder Detection System",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48",
                    UserId =3,
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    UserId =3,
                    ProjectId = 6,
                    ProjectName = "Mobile Metal Detector",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48",
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                }
            });
            modelBuilder.Entity<Education>().HasData(new[]
            {
                new Education()
                {
                    UserId =1,

                    EducationId = 1,
                    DegreeObtained = "HND",
                    SchoolName = "Lagos State Polytechnic",
                    Discipline = "Computer Engineering",
                    UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                },
                new Education()
                {
                    UserId =1,
                    EducationId = 2,
                    DegreeObtained = "OND",
                    SchoolName = "Lagos State Polytechnic",
                    Discipline = "Computer Engineering",
                    UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                },
                new Education()
                {
                    UserId =2,
                    EducationId = 3,
                    DegreeObtained = "BSC",
                    SchoolName = "Lagos State University",
                    Discipline = "Computer Science",
                    UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                },
                new Education()
                {
                    UserId =2,
                    EducationId = 4,
                    DegreeObtained = "MSc",
                    SchoolName = "University of Ibadan",
                    Discipline = "Software Engineering",
                    UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                },
                new Education()
                {
                    UserId =3,
                    EducationId = 5,
                    DegreeObtained = "BSc",
                    SchoolName = "Lagos State Polytechnic",
                    Discipline = "Biomedical Engineering",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                },
                new Education()
                {
                    UserId =3,
                    EducationId = 6,
                    DegreeObtained = "HND",
                    SchoolName = "Lagos State Polytechnic",
                    Discipline = "Soil Science",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                }
            });
            modelBuilder.Entity<UserServices>().HasData(new[]{
                new UserServices()
                {
                    UserId =1,
                    ServiceId = 1,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Web development",
                    UserProfileId = "2438b126-7410-43dc-84f8-f5e6c5c71289"
                },
                new UserServices()
                {
                    UserId =1,
                    ServiceId = 2,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Software Development",
                    UserProfileId ="2438b126-7410-43dc-84f8-f5e6c5c71289"
                },new UserServices()
                {
                    
                    ServiceId = 3,
                    UserId =1,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Project Management",
                    UserProfileId= "2438b126-7410-43dc-84f8-f5e6c5c71289"
                },new UserServices()
                {
                    UserId =2,
                    ServiceId = 4,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Mobile development",
                    UserProfileId ="77fe5873-b45c-482e-89f3-decad6c4ed3d"
                },new UserServices()
                {
                    UserId =2,
                    ServiceId = 5,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Front-End Development",
                    UserProfileId = "77fe5873-b45c-482e-89f3-decad6c4ed3d"
                },new UserServices()
                {
                    UserId =2,
                    ServiceId = 6,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Mean Stack Engineer",
                    UserProfileId  = "77fe5873-b45c-482e-89f3-decad6c4ed3d"

                },new UserServices()
                {
                    UserId =3,
                    ServiceId = 7,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Web development",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                },new UserServices()
                {
                    UserId =3,
                    ServiceId = 8,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Web development",
                    UserProfileId ="9e0444fb-e663-4b8a-88eb-1c9e256a0f48"

                },new UserServices()
                {
                    UserId =3,
                    ServiceId = 9,
                    ServiceDescription = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    ServiceName = "Web development",
                    UserProfileId = "9e0444fb-e663-4b8a-88eb-1c9e256a0f48"
                }

                }
            );
        }

        public List<UserProfile> SeedUserProfile()
        {
            var userProfiles = new List<UserProfile>();

            using (StreamReader r = new StreamReader(@"C:\Users\hp\source\repos\TechArtProfileProject\TechArtProfileProject.Lib.Infrastructure\UserProfileData.json"))
            {
                string json = r.ReadToEnd();
                userProfiles = JsonConvert.DeserializeObject<List<UserProfile>>(json);
            }

            return userProfiles;
        }

        public List<Project> SeedProjects()
        {
            var projects = new List<Project>
            {
                new Project()
                {
                    ProjectId = 1,
                    ProjectDescription ="Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    ProjectName ="Bank App",

                },
                new Project()
                {
                    ProjectId = 2,
                    ProjectName = "MVC",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 3,
                    ProjectName = "Fire Alarm",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 4,
                    ProjectName = "Mobile SMS Sender",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 5,
                    ProjectName = "Intruder Detection System",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                },
                new Project()
                {
                    ProjectId = 6,
                    ProjectName = "Mobile Metal Detector",
                    ProjectLink = "https://github.com/Aitem2012/BankAccountModel",
                    
                    ProjectDescription = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue. Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy. Fusce aliquet pede non pede. Suspendisse dapibus lorem pellentesque magna. Integer nulla. Donec blandit feugiat ligula"
                }
            };


            return projects;
        }

    }
}
