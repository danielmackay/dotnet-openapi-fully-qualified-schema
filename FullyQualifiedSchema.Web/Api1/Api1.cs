namespace FullyQualifiedSchema.Web.Api1;

public static class Api1
{
    private static readonly string[] _summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public static void MapApi1(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/weatherforecast1", () =>
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
            .WithName("GetWeatherForecast1")
            .Produces<WeatherForecast[]>();
    }

    record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary, string ApiProp1 = "API1")
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
