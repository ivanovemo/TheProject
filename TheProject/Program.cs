using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data;
using TheProject.Infrastructure.Data.Configuration;
using TheProject.Infrastructure.Data.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
    .EnableSensitiveDataLogging());

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/User/Login";
});

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IInstructorService, InstructorService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<ILectureService, LectureService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
       name: "areas",
        pattern: "{area:exists}/{controller=Course}/{action=Delete}/{id?}"
        );
    endpoints.MapControllerRoute(
       name: "areas",
        pattern: "{area:exists}/{controller=Course}/{action=Edit}/{id?}"
        );
    endpoints.MapControllerRoute(
       name: "areas",
        pattern: "{area:exists}/{controller=Course}/{action=Add}/{id?}"
        );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

await RolesConfiguration.SeedRoles(app.Services);
await UserRolesConfiguration.SeedUserRoles(app.Services);

app.MapRazorPages();

app.Run();