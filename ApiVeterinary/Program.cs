using System.Reflection;
using ApiVeterinary.Extensions;
using AspNetCoreRateLimit;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Add APlicationServiceExtensions */
builder.Services.AddApplicationService();
builder.Services.ConfigureCors();
builder.Services.ConfigureRateLimiting();

/* Add AutoMapper */
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());


/* Add Connection to DB */
builder.Services.AddDbContext<VeterinaryContext>(options =>
{
    string conectionStrings = builder.Configuration.GetConnectionString("MysqlConnect");
    options.UseMySql(conectionStrings, ServerVersion.AutoDetect(conectionStrings));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("CorsPolicy");
app.UseIpRateLimiting();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
