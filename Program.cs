var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Run(async context =>
{
    Console.WriteLine(context.Request.Method);
    if (context.Request.Path == "/hello")
    {
        context.Response.ContentType = "text/html";
        await context.Response.SendFileAsync("index.html");
    }
});
app.Run();
