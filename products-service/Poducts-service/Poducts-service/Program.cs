using Poducts_service.Config;
using Poducts_service.Middleware;
using Poducts_service.Repository;
using Poducts_service.Repository.Http;
using Poducts_service.Service;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddAutoMapper(Assembly.GetExecutingAssembly());

services.AddHttpClient();

services.AddSingleton<HttpConfiguration>();
services.AddSingleton<IProductsService, ProductsService>();
services.AddSingleton<IProductsRepository, ProductsHTTPClient>();

// services.Configure<HttpConfiguration>(IConfiguration.GetSection("myConfiguration"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors(p => p.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());

app.UseCors("corsapp");

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();

app.Run();
