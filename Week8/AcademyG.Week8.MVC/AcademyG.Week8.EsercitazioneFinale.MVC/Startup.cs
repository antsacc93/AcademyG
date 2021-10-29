using AcademyG.Week8.EsercitazioneFinale.EF;
using AcademyG.Week8.EsercitazioneFinale.EF.Repositories;
using AcademyG.Week8.EsercizioFinale.Core.BusinessLayer;
using AcademyG.Week8.EsercizioFinale.Core.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC
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
            services.AddScoped<IBusinessLayer, MainBusinessLayer>();
            services.AddScoped<IDishRepository, DishRepositoryEF>();
            services.AddScoped<IUserRepository, UserRepositoryEF>();
            services.AddScoped<IMenuRepository, MenuRepositoryEF>();

            services.AddDbContext<RestaurantContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("RestaurantDB"))
                );

            services.AddAuthorization(options => {
                options.AddPolicy("CatererPolicy", policy => policy.RequireRole("Caterer"));
                options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("Customer"));
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Users/Login");
                    options.AccessDeniedPath = new PathString("/Users/Forbidden");
                });

            services.AddControllersWithViews();
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
