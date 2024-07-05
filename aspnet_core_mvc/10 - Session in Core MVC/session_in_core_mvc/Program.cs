var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Add distributed memory cache to store session data
builder.Services.AddDistributedMemoryCache();

// Add Session Services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);     // Set sesssion timeout
    options.Cookie.HttpOnly = true;                     // Make the session cookie HTTP-only
    options.Cookie.IsEssential = true;                  // Make the session cookie essential
});

var app = builder.Build();

// Enable session before MVC middleware
app.UseSession();

app.MapGet("/", () => "Hello World!");

app.Run();
