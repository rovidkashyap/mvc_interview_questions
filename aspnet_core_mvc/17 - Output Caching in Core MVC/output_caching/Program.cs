using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddResponseCaching();
builder.Services.AddControllersWithViews(options =>
{
    options.CacheProfiles.Add("Default", new Microsoft.AspNetCore.Mvc.CacheProfile
    {
        Duration = 60
    });

    options.CacheProfiles.Add("NoCache", new Microsoft.AspNetCore.Mvc.CacheProfile
    {
        NoStore = true,
        Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None
    });
});

var app = builder.Build();

app.UseResponseCaching();       // Enable response caching middleware

app.MapGet("/", () => "Hello World!");

app.Run();
