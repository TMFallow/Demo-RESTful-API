using Microsoft.EntityFrameworkCore;
using Teacher_Repo;
using Teacher_Service;
using Web_Teacher;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Teacher_Repo_Context>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        t => t.MigrationsAssembly("Teacher_Repo")));

builder.Services.AddScoped(typeof(ITeacher_Repo<>), typeof(Teacher_Repo<>));

builder.Services.AddTransient<ITeacher_Service, Teacher_Services>();

builder.WebHost.ConfigureServices(s => s.AddSingleton(builder)).ConfigureAppConfiguration(i => i.AddJsonFile(Path.Combine("configuration", "configuration.json"))).UseStartup<StartUp>();

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
