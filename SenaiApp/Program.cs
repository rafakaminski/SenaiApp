using Microsoft.EntityFrameworkCore;
using SenaiApp.Repository.Context;
using SenaiApp.Service.Interfaces;
using SenaiApp.Service.Services;

namespace SenaiApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region Inje��o de Depend�ncia

            builder.Services.AddDbContext<SenaiAppContext>(options =>
                options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:AppSenai")));

            builder.Services.AddScoped<IClienteService, ClienteService>();

            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}