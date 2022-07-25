using Microsoft.EntityFrameworkCore;
using Practicaweb.API;
using Practicaweb.API.DBContexts;
using Practicaweb.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); //Permite usar herencia de controladores
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<UsersData>(); //Inyeccion de dependencias
//Mientras se ejecute la aplicacion va a existir una instancia de la clase de arriba

builder.Services.AddDbContext<InfoUsersContext>(dbContextOptions => dbContextOptions.UseSqlite("Data Source=InformacionUsers.db"));

builder.Services.AddScoped<IInfoUsersRepository, InfoUsersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Verifica el mapeo de la URL

app.Run();

