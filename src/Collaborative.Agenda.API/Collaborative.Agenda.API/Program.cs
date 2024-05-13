using Collaborative.Agenda.MongoDB.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = config.GetConnectionString("MongoDB");
var databaseName = config.GetValue<string>("MongoDB:DatabaseName");

if(string.IsNullOrWhiteSpace(connectionString))
{
    throw new Exception("Connection string is not informed.");
}

if (string.IsNullOrWhiteSpace(databaseName))
{
    throw new Exception("database name is not informed.");
}

builder.Services.IncludeMongoServices(connectionString, databaseName);

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