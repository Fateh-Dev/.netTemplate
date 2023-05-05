using Microsoft.EntityFrameworkCore;
using Template;
using Template.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Registering Globale Service To Store Shared Data
builder.Services.AddSingleton<AppStoreService>();

// Registering Service that loads lookups | configurations | Seed Data at startup 
builder.Services.AddHostedService<LookupsLoaderService>();

builder.Services.AddScoped<IPersonneRepo, SqlPersonneRepo>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Connecting To Database
builder.Services.AddDbContext<TemplateContext>(opt => opt.UseSqlServer(
   builder.Configuration.GetConnectionString("SqlServerConnection")
));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
