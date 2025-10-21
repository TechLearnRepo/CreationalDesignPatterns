using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDesignPattern.SingletonDesignPattern
{
    // Sealed prevents subclassing so the construction semantics can't be changed by derived types.
    public sealed class Logger
    {
        // Lazy<T> ensures the Logger is created only on first access and is thread-safe by default.
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        // Private constructor prevents external code from creating additional instances.
        private Logger()
        {
            
        }

        // Global access point for the single Logger instance.
        // Accessing InstanceOfLogger triggers lazy initialization on first use and always returns the same instance.
        public static Logger InstanceOfLogger 
        { 
            get 
            {
                return instance.Value;
            }  
        }
    
        public void Log(string message)
        {
            Console.WriteLine($"Log entry: {message}");
        }   
    }
}
