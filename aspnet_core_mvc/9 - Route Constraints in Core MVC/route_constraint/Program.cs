using route_constraint.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Adding Custom Constraints
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("customconstraint", typeof(CustomConstraint));
});

var app = builder.Build();

// Using Inline Constraints
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id:int?}");

// Using Custom Route Constraints
app.MapControllerRoute(
    name: "custom",
    pattern: "{controller=Home}/{action=Index}/{id:customconstraint?}");

// Using Route Constraints in Middleware
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id:int?}")
    .WithMetadata(new CustomRouteConstraint());


// Regular Expression Constraints
app.MapControllerRoute(
    name: "regex",
    pattern: "{controller=Home}/{action=Index}/{id:regex(^\\d{{6}}$)}");  // Id must be 6-digit number

app.MapGet("/", () => "Hello World!");

app.Run();
