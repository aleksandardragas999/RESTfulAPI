

using API.Data;
using API.Logging;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("log/villaLogs.txt",rollingInterval:RollingInterval.Day).CreateLogger();

builder.Host.UseSerilog();
*/

//Add DbContext

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers(options => 
{
//   // options.ReturnHttpNotAcceptable = true;//ako formati nije prihvatilj vratice odgovarajucu poruku o gresci dozvole
}).AddNewtonsoftJson();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*Kada registrujemo service ,maksimalni ili najduzi  vijek trajanja
 *  je u singletonu, to se kreira kada se aplikacija  pokrene i taj objekat
 *  ce se koristiti  svaki put kada  aplikacija zatrazi implementacije.
 */
builder.Services.AddSingleton<ILogging, LoggingV2>();

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
