using Greatanimelist.Server.DataAccess;
using Greatanimelist.Shared;
using Microsoft.EntityFrameworkCore;
using Greatanimelist.Server.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();

builder.Services.AddDbContext<AnimeContext>(options =>
{
	var connectionString = builder.Configuration.GetConnectionString("AnimeDb");
	options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<AnimeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapFallbackToFile("index.html");


app.MapGet("/AllAnimes", (AnimeRepository repo) =>
{
	return Results.Ok(repo.GetAllAnimes());
});

app.MapPost("/AddAnimes", (AnimeRepository repo, Anime anime) =>
{
	repo.add(anime);
	return Results.Ok("Added anime");
});
app.Run();
