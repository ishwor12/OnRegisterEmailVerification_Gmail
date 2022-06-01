using IdentityManager.Data;
using IdentityManager.GenericRepository.Interface;
using IdentityManager.GenericRepositorys;
using IdentityManager.Interface;
using IdentityManager.Models;
using IdentityManager.Repo;
using IdentityManager.Repo.Interface;
using IdentityManager.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IdentityManager
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); //=> lambda expression

            services.AddTransient<IEmailSender, EmailSender>(); //email sender dependencies
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>)); // generic repo and its interface
            services.AddDefaultIdentity<ApplicationUser>()
                .AddRoles<IdentityRole>()                
                .AddRoleManager<RoleManager<IdentityRole>>()
                //.IdentityRole<int>
                .AddEntityFrameworkStores<ApplicationDbContext>();
           // services.AddScoped<IDeptment, DepartmentRepo>();
            services.AddScoped<IStudentRepo, GenericRepository.Interface.StudentRepo>();

            services.AddControllersWithViews();
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AtLeast21", policy =>
            //        policy.Requirements.Add(new policy));
            //});


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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
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
