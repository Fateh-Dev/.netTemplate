using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Template;
using Template.Authorization;
using Template.Data;
using Template.Helpers;
using Template.Services;
var builder = WebApplication.CreateBuilder(args);

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

builder.Services.AddCors();
builder.Services.AddControllers();

// configure strongly typed settings object
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// configure automapper with all automapper profiles from this assembly
builder.Services.AddAutoMapper(typeof(Program));

// configure DI for application services
builder.Services.AddScoped<IJwtUtils, JwtUtils>();
builder.Services.AddScoped<IUserService, UserService>();

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
// configure HTTP reque 

// global cors policy
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();
// custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.UseResponseCaching();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
