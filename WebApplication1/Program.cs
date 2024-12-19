using Lab2.Interfaces;
using Lab2.Lab6;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//#if DEBUG
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
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
