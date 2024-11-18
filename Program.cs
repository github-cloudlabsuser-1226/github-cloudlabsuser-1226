using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

// Configure the app to return index.html when the root URL is accessed (Objective 5)
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.html" }
});
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapFallbackToFile("index.html");
});
app.Run();
