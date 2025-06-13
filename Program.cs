using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "SignalR Server is running!");
app.MapHub<QuizHub>("/quizhub");

app.Run();

public class QuizHub : Microsoft.AspNetCore.SignalR.Hub
{
    public async Task SendAnswer(string user, string answer)
    {
        await Clients.All.SendAsync("ReceiveAnswer", user, answer);
    }
}
