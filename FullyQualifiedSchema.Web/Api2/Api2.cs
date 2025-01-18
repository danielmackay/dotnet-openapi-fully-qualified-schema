namespace FullyQualifiedSchema.Web.Api2;

public static class Api2
{
    private static readonly string[] _summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public static void MapApi2(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/weatherforecast2", () =>
            {
                var forecast =  Enumerable.Range(1, 5).Select(index =>
                        new WeatherForecast
                        (
                            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                            Random.Shared.Next(-20, 55),
                            _summaries[Random.Shared.Next(_summaries.Length)]
                        ))
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast2")
            .Produces<WeatherForecast[]>();
    }
}

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary, string ApiProp2 = "API2")
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
