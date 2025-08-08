using Microsoft.EntityFrameworkCore;
using API.Data; // <-- Make sure this is there
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt => // fix latter
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

app.MapControllers();

app.Run();
