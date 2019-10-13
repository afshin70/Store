using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Models.DataBase.Context;
using Store.Models.IService;
using Store.Models.Services;
using Store.Models.Services.Admin;
using Store.Models.Utility.Convertor;

namespace Store
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StoreContext>(option =>
            option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //view Render
            services.AddTransient<IViewRenderService, RenderViewToString>();
            //data base service
            //AdminService 
            services.AddTransient<Models.IService.Admin.IProductService,Models.Services.Admin.ProductService>();
            services.AddTransient<Models.IService.Admin.IMainService, MainService>();
            //FrountService

            //public Service
            services.AddTransient<IFileService,FileService>();
            services.AddTransient<IUserService, UserService>();
            //Configure Authentication By Cooki Base
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;


            }).AddCookie(option =>
            {
                option.AccessDeniedPath = "/AccessDenied";
                option.LoginPath = "/Login";
                option.LogoutPath = "/Logout";
                option.ExpireTimeSpan = TimeSpan.FromDays(7);

            });
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseNotFoundPage_404Error();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areas",
                   template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
               
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
