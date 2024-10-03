using System.Reflection;
using DsInfer;

namespace DsInfer.CLI;

public static class Program
{
    public static int Main(string[] args)
    {
        var executablePath = Assembly.GetExecutingAssembly().Location;
        var executableDirPath = Path.GetDirectoryName(executablePath)!;
        var pluginsPath =
            Path.Combine(Path.GetDirectoryName(executableDirPath)!, "lib/plugins/dsinfer");

        using var env = new DsInfer.Environment();
        env.addPluginPath("com.diffsinger.InferenceDriver",
            Path.Combine(pluginsPath, "inferencedrivers"));
        env.addPluginPath("com.diffsinger.InferenceInterpreter",
            Path.Combine(pluginsPath, "inferenceinterpreters"));

        var inferenceReg = env.registry((int)ContributeSpec.Type.Inference).Cast<InferenceRegistry>();
        var driver = inferenceReg.createDriver("com.diffsinger.InferenceDriver.OnnxDriver");
        if (driver == null)
        {
            Console.WriteLine("Failed to create driver!");
            return -1;
        }

        JsonValue initArgs;
        {
            initArgs = JsonValue.fromJson(@"{ ""ep"": ""dml"" }", out var error);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Error initializing driver 1: {error}");
                return -1;
            }
        }
        Console.WriteLine("OK!");
        {
            var error = new Error();
            if (!driver.initialize(initArgs, error))
            {
                Console.WriteLine($"Error initializing driver 2: {error.message()}");
                return -1;
            }
        }
        inferenceReg.setDriver(driver);
        return 0;
    }
}