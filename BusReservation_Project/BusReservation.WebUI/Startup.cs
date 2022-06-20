using BusReservation.Business.Abstract;
using BusReservation.Business.Concrete;
using BusReservation.Data.Abstract;
using BusReservation.Data.Concrete;
using BusReservation.WebUI.EmailServices;
using BusReservation.WebUI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI
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
            services.AddDbContext<ApplicationContext>(options=>options.UseSqlite("Data Source = TicketDb"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options => {
                //Password Restrictions
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;

                //Lockout Restrictions
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

                //User 
                options.User.RequireUniqueEmail = true;

                //SignIn
                options.SignIn.RequireConfirmedEmail = true;

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = "BusReservation_Project.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });


            services.AddScoped<ITicketRepository, EfCoreTicketRepository>();
            services.AddScoped<ITicketService, TicketManager>();
            services.AddScoped<IDirectionRepository, EfCoreDirectionRepository>();
            services.AddScoped<IDirectionService, DirectionManager>();
            services.AddScoped<ICityRepository, EfCoreCityRepository>();
            services.AddScoped<IChooseSeatRepository, EfCoreChooseSeatRepository>();
            services.AddScoped<IChooseSeatService, ChooseSeatManager>();
            services.AddScoped<ICityService, CityManager>();


            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
               Configuration["EmailSender:Host"],
               Configuration.GetValue<int>("EmailSender:Port"),
               Configuration.GetValue<bool>("EmailSender:EnableSSL"),
               Configuration["EmailSender:UserName"],
               Configuration["EmailSender:Password"]
               ));


            services.AddControllersWithViews();
            services.AddRazorPages().AddViewOptions(options =>
                options.HtmlHelperOptions.ClientValidationEnabled = false
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
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
