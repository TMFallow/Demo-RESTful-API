using Student_Services;
using Student_Repo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Student_Repo_Context>(options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        t=>t.MigrationsAssembly("Student_Repo")));

builder.Services.AddScoped(typeof(IStudent_Repo<>), typeof(Student_Repo<>));

builder.Services.AddTransient<IStudent_Service, Student_Service>();

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
