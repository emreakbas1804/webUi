using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using static webUi.Program;

namespace webUi
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddMvc()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization(); 
            

           
            
            services.AddControllersWithViews();
                    


            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("tr"),
                    new CultureInfo ("en"),
                    new CultureInfo("es"),
                    new CultureInfo ("it")                    
                };

                opt.DefaultRequestCulture = new RequestCulture("tr");
                opt.SupportedCultures = supportedCultures;
                opt.SupportedUICultures = supportedCultures;
               
                opt.RequestCultureProviders = new[] {new RouteDataRequestCultureProvider(){
                    Options = opt
                }};

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            app.UseFileServer(new FileServerOptions()
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/content"),
                EnableDirectoryBrowsing = true
            });
            app.UseStatusCodePagesWithReExecute("/home/Error404", "?code={0}");
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();




            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);


            app.UseEndpoints(endpoints =>
            {                                

                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "/{controller=Home}/{action=Index}"
                );
                
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{culture}/{controller=Home}/{action=Index}"
                );

                endpoints.MapControllerRoute(
                    name: "ana-sayfa",
                    pattern: "{culture}/ana-sayfa",
                    defaults: new { controller = "home", action = "index" }
                );

                endpoints.MapControllerRoute(
                    name: "projelerimiz",
                    pattern: "{culture}/projelerimiz",
                    defaults: new { controller = "home", action = "projects" }
                );
                 endpoints.MapControllerRoute(
                    name: "projelerimiz",
                    pattern: "/projelerimiz",
                    defaults: new { controller = "home", action = "projects" }
                );

                endpoints.MapControllerRoute(
                    name: "adana1",
                    pattern: "{culture}/adana-unite-1",
                    defaults: new { controller = "projects", action = "adana1" }
                );
                 endpoints.MapControllerRoute(
                    name: "adana1",
                    pattern: "/adana-unite-1",
                    defaults: new { controller = "projects", action = "adana1" }
                );

                endpoints.MapControllerRoute(
                    name: "adana2",
                    pattern: "{culture}/adana-unite-2",
                    defaults: new { controller = "projects", action = "adana2" }
                );
                 endpoints.MapControllerRoute(
                    name: "adana2",
                    pattern: "/adana-unite-2",
                    defaults: new { controller = "projects", action = "adana2" }
                );

                endpoints.MapControllerRoute(
                    name: "aydin",
                    pattern: "{culture}/aydin-kagit",
                    defaults: new { controller = "projects", action = "aydin" }
                );
                 endpoints.MapControllerRoute(
                    name: "aydin",
                    pattern: "/aydin-kagit",
                    defaults: new { controller = "projects", action = "aydin" }
                );
                endpoints.MapControllerRoute(
                    name: "andritz",
                    pattern: "{culture}/andritz",
                    defaults: new { controller = "projects", action = "andritz" }
                );
                 endpoints.MapControllerRoute(
                    name: "andritz",
                    pattern: "/andritz",
                    defaults: new { controller = "projects", action = "andritz" }
                );
                endpoints.MapControllerRoute(
                    name: "MachineProjects",
                    pattern: "{culture}/tor-services-portable-lathe-machine-projects",
                    defaults: new { controller = "projects", action = "machineProjects" }
                );
                 endpoints.MapControllerRoute(
                    name: "MachineProjects",
                    pattern: "/tor-services-portable-lathe-machine-projects",
                    defaults: new { controller = "projects", action = "machineProjects" }
                );

                endpoints.MapControllerRoute(
                    name: "referanslar",
                    pattern: "{culture}/referanslarimiz",
                    defaults: new { controller = "home", action = "referances" }
                );
                 endpoints.MapControllerRoute(
                    name: "referanslar",
                    pattern: "/referanslarimiz",
                    defaults: new { controller = "home", action = "referances" }
                );
                endpoints.MapControllerRoute(
                    name: "kurumsal",
                    pattern: "{culture}/kurumsal",
                    defaults: new { controller = "home", action = "kurumsal" }
                );
                 endpoints.MapControllerRoute(
                    name: "kurumsal",
                    pattern: "/kurumsal",
                    defaults: new { controller = "home", action = "kurumsal" }
                );
                endpoints.MapControllerRoute(
                    name: "iletisim",
                    pattern: "{culture}/iletisim",
                    defaults: new { controller = "contact", action = "contact" }
                );
                 endpoints.MapControllerRoute(
                    name: "iletisim",
                    pattern: "/iletisim",
                    defaults: new { controller = "contact", action = "contact" }
                );

                endpoints.MapControllerRoute(
                    name: "teklif",
                    pattern: "{culture}/teklif",
                    defaults: new { controller = "contact", action = "offer" }
                );
                 endpoints.MapControllerRoute(
                    name: "teklif",
                    pattern: "/teklif",
                    defaults: new { controller = "contact", action = "offer" }
                );


            });
        }
    }
}
