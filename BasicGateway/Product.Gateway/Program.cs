using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", false, false);

builder.Services.AddControllers();
builder.Services.AddOcelot();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

await app.UseOcelot();

app.Run();
