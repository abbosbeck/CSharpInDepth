using AspDotNetInDepth.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
/*builder.Services.AddSwaggerGen();*/

var app = builder.Build();

app.UseMiddleware<CustomMiddleware>();

// Middleware 1: Logging
app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 1: Request received");
    await next();
    Console.WriteLine("Middleware 1: Response sent");
});

// Middleware 2: Authentication
app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 2: Authentication");
    await next();
});

// Middleware 3: Terminal Middleware (Handles request)
app.Run(async (context) =>
{
    Console.WriteLine("Middleware 3: Request handled");
    await context.Response.WriteAsync("Hello, World!");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from Termianl Middleware!");
});

app.Run();
