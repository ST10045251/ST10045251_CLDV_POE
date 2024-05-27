using Microsoft.EntityFrameworkCore;
using ST10045251_CLDV_POE.NewFolder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the database context with the connection string from appsettings.json
builder.Services.AddDbContext<KhumaloCraftContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("KhumaloCraftDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
