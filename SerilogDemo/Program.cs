using Serilog;

namespace SerilogDemo;

public static class Program
{
    public static void Main()
    {
        // Configure Serilog with different sinks

        // 1. File Sink
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Minute)
            .CreateLogger();
        
        Log.Information("This is an informational message.");
        Log.Warning("This is a warning message.");
        Log.Error("This is an error message.");
        Log.Fatal("This is a fatal message.");

        // Close and flush the log
        Log.CloseAndFlush();
    }
}