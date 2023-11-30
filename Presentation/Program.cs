var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllersWithViews();
app.MapControllerRoute(
    name: "deafault",
    pattern: "{controller}/{action}/{id}"
    );

app.MapGet("/", () => "Hello World!");

app.Run();
