var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Convention-Based Routing

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapGet("/", () => "Hello World!");

app.Run();
