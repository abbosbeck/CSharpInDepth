using System.Net.WebSockets;

var builder = WebApplication.CreateBuilder(args); 
var app = builder.Build();

var webSocketOptions = new WebSocketOptions()
{
    KeepAliveInterval = TimeSpan.FromSeconds(120),
};
app.UseWebSockets(webSocketOptions);

// WebSocket endpoint middleware
app.Map("/ws", async context =>
{
    if (context.WebSockets.IsWebSocketRequest)
    {
        using WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
        await Echo(webSocket);
    }
    else
    {
        context.Response.StatusCode = 400;
    }
});

app.MapGet("/", () => "Hello, Minimal API!");
app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");
app.MapPost("/add", (int a, int b) => Results.Json(new { sum = a + b }));
async Task Echo(WebSocket webSocket)
{
    throw new NotImplementedException();
}

app.Run();
*/

using AspDotNetInDepth.DataAccess;
using AspDotNetInDepth.ExceptionFilters;
using AspDotNetInDepth.Middlewares;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{

});

builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV"; // Formats as "v1", "v2", etc.
    options.SubstituteApiVersionInUrl = true; // Replaces {version} in route templates
});

var app = builder.Build();

//app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseMiddleware<CustomMiddleware>();

/*app.Services.AddDbContext<PlayersDBContext>(options => options.UseInMemory);*/
app.Services.AddMediatR(configuration =>
{
    configuration.
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

        foreach (var description in provider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
        }
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/