using System.Globalization;
namespace eShop.Store.Reviews;
using Microsoft.Extensions.Logging;

internal class Program
{
    private static readonly ILogger<Program>? _logger; // Add a private static ILogger field
        private static int Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddHostedService<BackgroundReviewValidation>();

        var app = builder.Build();

        app.MapGet("/scrub", () =>
        {
            string x = Math.PI.ToString();
            for (int i = 0; i < 1000; i++)
            {
                x = x + Random.Shared.Next(0, 10).ToString();
                if (i % 50 == 0)
                {
                    ReviewValidation.StringValidation("Working...", 'X', CultureInfo.CurrentCulture);
                    _logger.LogInformation($"Number: {i}");
                }
            }

            return ReviewValidation.StringValidation($"PI is {x}", 'X', CultureInfo.CurrentCulture);
        });

        app.MapGet("/", () => "Hello World! V4 4/30/24");
        app.Run();

        return 0;
    }
}
