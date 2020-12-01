using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VendasWeb.DAL;
using VendasWeb.Models;
using VendasWeb.Utils;

namespace VendasWeb
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
            });

            services.AddScoped<ProdutoDAO>();
            services.AddScoped<CategoriaDAO>();
            services.AddScoped<ItemVendaDAO>();
            services.AddScoped<Sessao>();

            services.AddHttpContextAccessor();

            services.AddDbContext<Context>
                (options => options.UseSqlServer(
                    Configuration.GetConnectionString("Connection")));

            services.AddIdentity<Usuario, IdentityRole>().
                AddEntityFrameworkStores<Context>().
                AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Usuario/Login";
                options.AccessDeniedPath = "/Usuario/AcessoNegado";
            });

            services.AddSession();
            services.AddControllersWithViews().AddNewtonsoftJson(
                options => options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
