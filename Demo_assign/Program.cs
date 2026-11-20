using Demo_assign.MiddleWares;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Server.HttpSys;

namespace Demo_assign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // register services for api
            //builder.Services.AddControllers();
            //register services for mvc
            //builder.Services.AddMvc();
            //register services for mvc core
            //builder.Services.AddMvcCore();



            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            //register
            app.UseMiddleware<RequestTimingMiddleware>();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            //inline middleware
            //app.Use(async (context, next) =>
            //{
            //    //before next request
            //    Console.WriteLine($"hello");
            //    //next
            //    await next(context);
            //    //after next response
            //    Console.WriteLine($"bye");
            //});


            app.UseAuthorization();
            //app.UseStaticFiles();
            //cross origin resource sharing
            //app.UseCors();
            ////who logged in 
            //app.UseAuthentication();
            //enable app to read or write seesion data
            //app.UseSession();
            app.MapStaticAssets();
            //app.MapControllerRoute(
            //    name: "shop",
            //    pattern: "{controller}/{action}/{id?}",
            //    defaults: new
            //    {
            //        controller = "products",
            //        action = "TestRouting"
            //    },
            //    constraints: new
            //    {
            //        id = new IntRouteConstraint()
            //    }
            //    );

            //app.MapControllerRoute(
            //    name: "shop",
            //    pattern: "{controller=products}/{action=TestRouting}/{id:int?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
