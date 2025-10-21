using SingleDesignPattern.FactoryDesignPattern;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


#region Factory Design Pattern Demonstration

using IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddTransient<ConsoleLogger>();
                    services.AddTransient<FileLogger>();
                    services.AddTransient<DatabaseLogger>();
                    services.AddSingleton<LoggerFactory>();
                })
                .Build();

var factory = host.Services.GetRequiredService<LoggerFactory>();

var consoleLogger = factory.CreateLogger(LoggerType.Console);
consoleLogger.Log("User registration logged in console.");

var fileLogger = factory.CreateLogger(LoggerType.File);
fileLogger.Log("User registration logged in file.");

var dbLogger = factory.CreateLogger(LoggerType.Database);
dbLogger.Log("User registration logged in database.");

Console.WriteLine("All logs processed via DI-based factory.");
Console.ReadKey();
#endregion