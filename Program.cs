var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "SignalR Server is running!");

app.MapHub<GameHub>("/gamehub");

app.Run();