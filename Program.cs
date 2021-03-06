using InfoNinjasApi.Data;
using InfoNinjasApi.Features.NinjaFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AzureSQL")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Automapper to be used in mapping db <=> dto
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Connect de
builder.Services.AddScoped<INinjaService, NinjaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();
app.EnsureStandardDatabaseInitialized();
app.MapControllers();

app.Run();
