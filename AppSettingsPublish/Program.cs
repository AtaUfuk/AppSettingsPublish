var builder = WebApplication.CreateBuilder(args);
string env = builder.Environment.EnvironmentName;
builder.Configuration.AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true);
Console.WriteLine($"Using configuration for environment: {env}");
Console.WriteLine($"ConStr value: {builder.Configuration.GetSection("ConStr").Value}");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.RunAsync();
