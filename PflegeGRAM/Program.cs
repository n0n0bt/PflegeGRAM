using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PflegeGRAM.Areas.Identity.Data;
using PflegeGRAM.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PflegeGRAMDBContextConnection") ?? throw new InvalidOperationException("Connection string 'PflegeGRAMDBContextConnection' not found.");

builder.Services.AddDbContext<PflegeGRAMDBContext>(options => options.UseSqlServer(connectionString));


//Automatski dodato u scaffold /Mujo uradio scaffold
builder.Services.AddDefaultIdentity<PflegeGRAMBenutzer>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<PflegeGRAMDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

//Mujo dodao
builder.Services.AddRazorPages();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireUppercase = false;
});



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

//Mujo dodao
app.MapRazorPages();

app.Run();
