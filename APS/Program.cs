using APS.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Google App Service Routing
//var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
//var url = $"http://0.0.0.0:{port}";

// Add services to the container.
builder.Services.AddRazorPages();

// Add EF Core
builder.Services.AddDbContext<APSContext>(
    options => options.UseSqlServer(Environment.GetEnvironmentVariable("APS_DB_CONTEXT")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days.
    // You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//app.Run(url);
app.Run();
