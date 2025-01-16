using Lab2.Interfaces;
using Lab2.Lab6;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LibraryDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//#if DEBUG
builder.Services.AddScoped<IBookRepository, ADONETBookRepository>();
builder.Services.AddScoped<IPersonRepository, EFPeronRepository>();
/*#else
builder.Services.AddScoped<IBookRepository, BookRepository>();
#endif*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
