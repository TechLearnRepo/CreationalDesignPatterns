using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignPattern.FactoryDesignPattern
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger()
        {
            _filePath = "log.txt"; // Default log file path
        }
        public void Log(string message)
        {
            File.AppendAllText(_filePath, $"File Logger: {message}{Environment.NewLine}");
        }
    }
}
