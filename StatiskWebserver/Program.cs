WebApplication app = WebApplication.Create(); //Skapar en ny webbapplikation

app.UseDefaultFiles(); //Middleware: Ser till så att index.html används som default om ingen fil anges i URL:en
app.UseStaticFiles(); //Middleware: Ser till så att filer i katalogen wwwroot kan nås via URL:en

app.Run(); //Startar webbservern
