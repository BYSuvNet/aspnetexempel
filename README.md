# Enkla exempelprojekt

Dessa projekt finns i detta repo. Listade i komplexitetsordning. Många filer som kommer automatiskt med de olika 'dotnet new X' kommandona har tagits bort om de inte är nödvändiga för exmplen, exempelvis appsettings.json och massa boilerplatekod i MVC.

### StatiskWebserver
En så enkelt aspnet webserver som möjligt. Skickar tillbaka filer som ligger i wwwroot. 

### MinimalWebApi
Ett så enkelt webapi som möjligt. Har några endpoints för GET som returnerar olika data.

### WebApi
Ett webapi som som använder sig av en controller-klass. Fungerar i övrigt som MinimalWebApi.

### MVCWebserver
En så enkelt MVC-webserver som möjligt. Har en controller som kan returnera två olika views, Index och About.
