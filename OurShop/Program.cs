using Microsoft.EntityFrameworkCore;
using Repositories;
using Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddDbContext<ShopContext>(options => options.UseSqlServer("Server=TZIPPY53\\SQLEXPRESS; Database=Shop; Trusted_Connection=True; TrustServerCertificate=True")
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
