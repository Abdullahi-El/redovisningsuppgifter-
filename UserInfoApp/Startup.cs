using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace UserInfoApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // Register MVC services
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Show detailed errors in development
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Redirect to error page in production
                app.UseHsts(); // Use HTTP Strict Transport Security
            }

            app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
            app.UseStaticFiles(); // Enable serving static files

            app.UseRouting(); // Enable routing

            app.UseAuthorization(); // Enable authorization

            // Configure the endpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Index}/{id?}"); // Set default route
            });
        }
    }
}
