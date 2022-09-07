using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Yazlab2Proje1.data.Abstract;
using Yazlab2Proje1.data.Concrete.MySQL;
using Yazlab2Proje1.Identity;
using Yazlab2Proje1.Models;
using Firebase.Storage;
using Firebase.Auth;
using Google.Cloud.Firestore;

namespace Yazlab2Proje1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options=> options.UseMySQL("server=localhost;user=root;database=users;password=Eg67350311ad_!;port=3306"));
            services.AddIdentity<Users,IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options => {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = false;
                
                //lockout(şifre yanlış girildi uyarısı hesap kitlenmesi)
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.AllowedForNewUsers  = true;

                //user kayıt kuralları
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
            });
            services.ConfigureApplicationCookie(option => {
                option.LoginPath = "/account/login";
                option.LogoutPath = "/account/logout";
                //option.AccessDeniedPath = "account/accessdenied"; Bu gerekli değil ama kalsın.
                option.SlidingExpiration = true;
                option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                option.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = "Cookies"
                };
            });



            services.AddScoped<IRegisterRepository,MySQLRegisterRepository>();
            services.AddScoped<ILoginRepository,MySQLLoginRepository>();
            
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"
                    
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name : "default",
                    pattern: "{controller=account}/{action=login}/{id?}"

                );
            });
            
            
        }
    }
}
