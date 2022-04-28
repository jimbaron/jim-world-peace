var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "World peace is possible!");

app.Run();