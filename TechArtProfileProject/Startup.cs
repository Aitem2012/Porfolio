using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechArtProfileProject.Lib.Core.Abstraction;
using TechArtProfileProject.Lib.Core.Services;
using TechArtProfileProject.Lib.Infrastructure;
using TechArtProfileProject.Lib.Infrastructure.Abstraction;
using TechArtProfileProject.Lib.Infrastructure.Implementations;
using TechArtProfileProject.Models.Services;

namespace TechArtProfileProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContextPool<UserProfileDbContext>(option => option.UseSqlite(Configuration.GetConnectionString("TechArtConnection")));
            services.AddScoped<IUserProfileService, UserProfileService>();
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IEducationsService, EducationService>();
            services.AddScoped<IUserServiceRepository, UserServicesRepository>();
            services.AddScoped<IUserServicesService, UserServicesService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
