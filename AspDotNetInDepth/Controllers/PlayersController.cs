using AspDotNetInDepth.DataAccess;
using AspDotNetInDepth.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetInDepth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly PlayersDBContext _dbContext;

    public PlayersController(PlayersDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreatePlayer(Player player)
    {
        _dbContext.Players.Add(player);
        await _dbContext.SaveChangesAsync();
        
        return Ok(player.Id);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPlayerById(int id)
    {
        var player = await _dbContext.Players.FindAsync(id);

        return Ok(player);
    }
}