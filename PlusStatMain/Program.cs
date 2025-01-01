using Microsoft.Extensions.Configuration;
using DataTypes;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Database connection
IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Environment.CurrentDirectory).AddJsonFile("appSettings.json").Build();
SqlDbAccess db = new SqlDbAccess(configuration.GetConnectionString("PlusStatConnectionString"));

app.MapGet("/", () => "Hello World!");

app.Run();
