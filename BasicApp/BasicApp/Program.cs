using System.Reflection;
using BasicApp.Persistence;
using BasicApp.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("http://localhost:4200").AllowAnyOrigin().AllowAnyHeader();
}));


var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings");
builder.Services.AddDbContext<InterViewDbContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var assembly = AppDomain.CurrentDomain.Load("BasicApp.Application");
builder.Services.AddMediatR(assembly);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corspolicy");

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();



app.Run();
//await app.RunAsync();

