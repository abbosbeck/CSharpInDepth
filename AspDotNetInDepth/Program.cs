using AspDotNetInDepth.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
/*builder.Services.AddSwaggerGen();*/

var app = builder.Build();

/*// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

List<Game> games = new List<Game>()
{
    new Game { Id = 1, Name = "Game 1", Price = 100 },
    new Game { Id = 2, Name = "Game 2", Price = 200 },
    new Game { Id = 3, Name = "Game 3", Price = 300 }
};

//app.MapGet("games", () => games);

app.MapGet("/", () => "Hello World!");
app.MapGet("/user/{id}", (int id) => $"User ID: {id}");

//PUT /games/1
app.MapPut("games/{id}", (int id, Game updatedGame) =>
{
    int index = games.FindIndex(g => g.Id == id);
    Console.WriteLine("It is working here");

    games[index].Name = updatedGame.Name;

    return Results.NoContent();

});

app.Run();
