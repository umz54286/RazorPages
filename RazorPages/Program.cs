using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPages.Data;
using RazorPages.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesContext' not found.")));

var app = builder.Build();

// SeedData
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    SeedData.Initialize(services);
//}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
