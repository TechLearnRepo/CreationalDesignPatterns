using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignPattern.FactoryDesignPattern
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Database] {DateTime.Now}: Saved '{message}' to database.");
        }
    }
}
