using KUSYS_Project.Data.Concrete;
using KUSYS_Project.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("CourseConnection");
builder.Services.AddDbContext<CourseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(connectionString));

});
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<CourseContext>();



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
public class CourseContext : DbContext
{
    public CourseContext(DbContextOptions<CourseContext> options) : base(options) { }
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<StudentCourse> StudentCourses => Set<StudentCourse>();
}
