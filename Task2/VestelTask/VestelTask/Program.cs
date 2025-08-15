using VestelTask;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TextReverser>();

var app = builder.Build();



app.MapPost("/api/reverse", (ReverseText? req, TextReverser reverser) =>
{
    if (req is null || string.IsNullOrWhiteSpace(req.Text))
    {
        return Results.BadRequest(new { error = "Text cannot be empty." });
    }

    var reversed = reverser.Reverse(req.Text);
    return Results.Ok(new { reversedText = reversed });
});

app.Run();
