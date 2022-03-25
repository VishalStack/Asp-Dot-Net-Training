using CrudWebApiApp.Models;
using CrudWebApiApp.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BlogDBContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("BlogDBConnection")));
builder.Services.AddScoped<IPostRepository, PostRepository>();
var app = builder.Build();

//builder.Services.AddCors(option => option.AddPolicy("MyBlogPolicy", builder => {
//    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

//}));
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
