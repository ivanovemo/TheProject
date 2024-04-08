using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheProject.Core.Contracts;
using TheProject.Core.Services;
using TheProject.Infrastructure.Data;
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

app.MapRazorPages();

SeedRoles(app.Services).Wait();
SeedUserRoles(app.Services).Wait();

app.Run();

static async Task SeedRoles(IServiceProvider serviceProvider)
{
    using (var scope = serviceProvider.CreateScope())
    {
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        string[] roleNames = { "admin", "user" };
        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }
}


static async Task SeedUserRoles(IServiceProvider serviceProvider)
{
    using (var scope = serviceProvider.CreateScope())
    {
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        var adminRoleExists = await roleManager.RoleExistsAsync("admin");
        if (!adminRoleExists)
        {
            await roleManager.CreateAsync(new IdentityRole("admin"));
        }

        var userRoleExists = await roleManager.RoleExistsAsync("user");
        if (!userRoleExists)
        {
            await roleManager.CreateAsync(new IdentityRole("user"));
        }

        var adminUser = await userManager.FindByEmailAsync("admin1@gmail.com");
        if (adminUser != null && !(await userManager.IsInRoleAsync(adminUser, "admin")))
        {
            await userManager.AddToRoleAsync(adminUser, "admin");
        }

        var userUser = await userManager.FindByEmailAsync("user1@gmail.com");
        if (userUser != null && !(await userManager.IsInRoleAsync(userUser, "user")))
        {
            await userManager.AddToRoleAsync(userUser, "user");
        }
    }
}
