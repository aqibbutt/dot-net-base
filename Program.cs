global using AutoMapper;
global using Microsoft.EntityFrameworkCore;
global using Rest_Demo.DTO;
global using Rest_Demo.Models;
global using Rest_Demo.Service;
using Rest_Demo.Data;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddDbContext<DbContext>(options =>
// options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));
builder.Services.AddDbContext<DataContext>(options =>
  options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// configure strongly typed settings object
//builder.Services.Configure<DbSettings>(builder.Configuration.GetSection("DbSettings"));

//// configure DI for application services
//builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    //var context = services.GetRequiredService<DataContext>();
    //context.Database.EnsureCreated();
    //DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


