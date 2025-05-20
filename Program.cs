using Microsoft.EntityFrameworkCore;
using SchoolManagementAppMVC.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SchoolManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementDbContext") ?? throw new InvalidOperationException("Connection string 'SchoolManagementDbContext' not found.")));
var conn = builder.Configuration.GetConnectionString("SchoolManagementDb");
builder.Services.AddDbContext<SchoolMangementDbContext>(q => q.UseSqlServer(conn));
// Add services to the container.
builder.Services.AddControllersWithViews();

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
