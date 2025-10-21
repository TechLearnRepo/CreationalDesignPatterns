using SingleDesignPattern.SingletonDesignPattern;


#region Singleton Design Pattern Demonstration

//Demonstrates concurrent access to the Singleton logger using Parallel.For.
//This runs iterations potentially in parallel on thread-pool threads to show thread-safe initialization and shared use.
System.Threading.Tasks.Parallel.For(0, 5, i =>
{
    // Obtain the single Logger instance and write a message.
    // - The first call to InstanceOfLogger triggers Lazy<Logger>.Value which lazily and safely initializes the singleton.
    // - Console.WriteLine is used here for demonstration; when multiple threads write concurrently the output order may interleave.
    Logger.InstanceOfLogger.Log($"Message from thread {i}");
});

#endregion