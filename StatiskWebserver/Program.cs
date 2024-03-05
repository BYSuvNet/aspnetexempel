//Skapa en ny webbapplikation utan builder pattern (vi kan då inte lägga till services)
WebApplication app = WebApplication.Create();

app.UseDefaultFiles(); //Middleware: Ser till så att index.html används som default om ingen fil anges i URL:en
app.UseStaticFiles(); //Middleware: Ser till så att filer i katalogen wwwroot kan nås via URL:en

app.Run(); //Startar webbservern
