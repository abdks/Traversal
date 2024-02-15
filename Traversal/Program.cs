using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
using DatatAccessLayer.Abstract;
using DatatAccessLayer.Concrete;
using DatatAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using Traversal.Models;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureServices((hostingContext, services) =>
                {
                    services.AddDbContext<Context>();

                    services.AddLogging(x =>
                    {
                        x.ClearProviders();
                        x.SetMinimumLevel(LogLevel.Debug);
                        x.AddDebug();
                        var path = Directory.GetCurrentDirectory();
                        x.AddFile($"{path}\\Logs\\Log1.txt");
                    });

                    services.AddIdentity<AppUser, AppRole>()
                        .AddEntityFrameworkStores<Context>()
                        .AddErrorDescriber<CustomIdentityValidator>()
                        .AddEntityFrameworkStores<Context>();

                    services.AddControllersWithViews();

                    services.ContainerDep();

                    services.AddControllersWithViews(opt =>
                    {
                        var policy = new AuthorizationPolicyBuilder()
                            .RequireAuthenticatedUser()
                            .Build();
                        opt.Filters.Add(new AuthorizeFilter(policy));
                    });
                })
                .Configure(app =>
                {
                    var env = app.ApplicationServices.GetService<IWebHostEnvironment>();

                    if (!env.IsDevelopment())
                    {
                        app.UseExceptionHandler("/Home/Error");
                        app.UseHsts();
                    }

                    app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

                    app.UseHttpsRedirection();
                    app.UseStaticFiles();
                    app.UseAuthentication();
                    app.UseRouting();

                    app.UseAuthorization();

                    app.UseEndpoints(endpoints =>
                    {
                        endpoints.MapControllerRoute(
                            name: "areas",
                            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );

                        endpoints.MapControllerRoute(
                            name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");
                    });
                });
            });
}
