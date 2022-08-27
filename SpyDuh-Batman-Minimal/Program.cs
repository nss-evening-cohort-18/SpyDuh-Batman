using SpyDuh_Batman.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
var userData = new List<User>() {
          new User()
        {
            Id = 1,
            CodeName = "Spiffy",
            Friends = new List<int>()
            {
                3,2
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<Skill>()
            {
                new Skill(1)
                {
                    Name = "explosions",
                    isExpert = true
                },
                new Skill(2)
                {
                    Name = "guns",
                    isExpert = false
                },
                new Skill(3)
                {
                    Name = "C#",
                    isExpert = false
                }
            },
            HasSideKick = true
        },
          new User()
        {
            Id = 2,
            CodeName = "Blimpo",
            Friends = new List<int>()
            {
                1,3
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<Skill>()
            {

            },
            HasSideKick = false
        },
          new User()
        {
            Id = 3,
            CodeName = "Elsa",
            Friends = new List<int>()
            {
                1,2
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<Skill>()
            {

            },
            HasSideKick = true

        },
          new User()
        {
            Id = 4,
            CodeName = "Kris",
            Friends = new List<int>()
            {

            },
            Enemies = new List<int>()
            {
                1,2,3
            },
            Skills = new List<Skill>()
            {

            },
            HasSideKick = false
        }
        };
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "is ok"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 300),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");
app.MapGet("/user", () =>
{
    return userData;
});
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}