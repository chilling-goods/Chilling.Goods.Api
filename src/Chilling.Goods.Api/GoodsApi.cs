using Asp.Versioning.Conventions;
namespace Chilling.Goods.Api;

public static class GoodsApi
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder routes)
    {
        var version = routes.NewApiVersionSet()
            .HasApiVersion(1.0)
            .ReportApiVersions()
            .Build();
        
        // example 1
        routes.MapGet("/weatherforecast-func", GetWeatherForecast)
            .Produces(200)
            .WithApiVersionSet(version)
            .MapToApiVersion(1.0);
        
        // example 2
        routes.MapGet("/weatherforecast", () =>
            {
                var summaries = new[]
                {
                    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                };
                var forecast =  Enumerable.Range(1, 5).Select(index =>
                        new WeatherForecast
                        (
                            DateTime.Now.AddDays(index),
                            Random.Shared.Next(-20, 55),
                            summaries[Random.Shared.Next(summaries.Length)]
                        ))
                    .ToArray();
                return forecast;
            })
            .Produces(200)
            .WithApiVersionSet(version)
            .MapToApiVersion(1.0)
            .WithName("GetWeatherForecast");

        return routes;
    }

    private static WeatherForecast[] GetWeatherForecast()
    {
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        var forecast =  Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateTime.Now.AddDays(index),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    }
}

record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}