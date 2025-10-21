using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection; // Add this using directive

namespace SingleDesignPattern.FactoryDesignPattern
{
    public class LoggerFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public LoggerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILogger CreateLogger(LoggerType loggerType)
        {
            return loggerType switch
            {
                LoggerType.Console => _serviceProvider.GetRequiredService<ConsoleLogger>(),
                LoggerType.File => _serviceProvider.GetRequiredService<FileLogger>(),
                LoggerType.Database => _serviceProvider.GetRequiredService<DatabaseLogger>(),
                _ => throw new NotSupportedException($"Logger type '{loggerType}' not supported.")
            };  
        }
    }
}
