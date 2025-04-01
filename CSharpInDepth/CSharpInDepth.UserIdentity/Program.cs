using CSharpInDepth.UserIdentity.Application.Abstractions;
using CSharpInDepth.UserIdentity.Authentication;
using CSharpInDepth.UserIdentity.Database;
using CSharpInDepth.UserIdentity.Extensions;
using CSharpInDepth.UserIdentity.OptionsSetup;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IJWTProvider, JwtProvider>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMediatR(configuration =>
{
    configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
});


builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

builder.Services.ConfigureOptions<JwtOptionsSetup>();
builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();

/*builder.Services.AddAuthentication()
    .AddCookie(IdentityConstants.ApplicationScheme);
*/

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddApiEndpoints();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.ApplyMigrations();

app.MapGet("users/me", async (ClaimsPrincipal claims, ApplicationDbContext context) =>
{
    string userId = claims.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;

    return await context.Users.FindAsync(userId);
}).RequireAuthorization();

app.UseHttpsRedirection();

app.MapIdentityApi<User>();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
