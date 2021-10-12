using Microsoft.EntityFrameworkCore;
using WebExample.DataAccess;

class Programm
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        string connString = builder.Configuration.GetConnectionString("DefaultConnection");

        // Add services to the container.
        builder.Services.AddControllersWithViews();
       
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Car}/{action=CarData}/{id?}");

        app.Run();

        //Database First 
        //Scaffold-DbContext "Server=VACHMIRLAPTOP;Database=DeleteMe;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

        // Code First 
        // Add - Migration Initial -Context DeleteMeContext
        // Update - Database
        // Update - database - Context DeleteMeContext

        // Update - Database - Migration 0
        // Remove - Migration
    }
}