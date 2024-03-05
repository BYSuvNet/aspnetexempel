//Skapa en ny webbapplikation utan builder pattern (vi kan då inte lägga till services)
WebApplication app = WebApplication.Create();

//Registera några endpoint som svarar på GET requests
app.MapGet("/", () => "Hello World!");
app.MapGet("/time", () => "Time on server: " + DateTime.Now.ToString("HH:mm:ss"));
app.MapGet("/json", () => new { Name = "John Doe", Age = 42, City = "Stockholm" });

//Starta webbapplikationen
app.Run();
