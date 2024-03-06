// Skapa en builder för att konfigurera webbapplikationen med olika services
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Lägg till stöd för att använda controllers med vyer (HTML-sidor)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMyService, MyService>();
builder.Services.AddHttpClient();

WebApplication app = builder.Build();

// Lägg till routing (Läs mer här: https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/routing)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
