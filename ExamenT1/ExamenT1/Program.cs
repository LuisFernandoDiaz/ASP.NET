using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ExamenT1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ExamenT1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cn") ?? throw new InvalidOperationException("Connection string 'cn' not found.")));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
