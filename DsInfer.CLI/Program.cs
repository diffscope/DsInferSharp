using System.Reflection;

namespace DsInfer.CLI;

public static class Program
{

    public static int Main(string[] args)
    {
        var executablePath = Assembly.GetExecutingAssembly().Location;
        var executableDirPath = Path.GetDirectoryName(executablePath)!;
        var pluginsPath = Path.Combine(Path.GetDirectoryName(executableDirPath)!, "lib/plugins/dsinfer");

        using var env = new Environment();

        // Initialize plugin factory
        env.addPluginPath("com.diffsinger.InferenceDriver", Path.Combine(pluginsPath, "inferencedrivers"));
        env.addPluginPath("com.diffsinger.InferenceInterpreter", Path.Combine(pluginsPath, "inferenceinterpreters"));

        // Create driver
        var inferenceReg = env.registry((int)ContributeSpec.Type.Inference).Cast<InferenceRegistry>();
        var driver = inferenceReg.createDriver("com.diffsinger.InferenceDriver.OnnxDriver");
        if (driver == null)
        {
            Console.WriteLine("Failed to create driver!");
            return -1;
        }

        // Initialize driver
        {
            // Build driver initial arguments
            var initArgs = new JsonObject();
            initArgs["ep"] = new JsonValue("dml");

            var json = new JsonValue(initArgs);
            Console.WriteLine(json.toJson(4));

            // Initialize
            var error = new Error();
            if (!driver.initialize(new JsonValue(initArgs), error))
            {
                Console.WriteLine($"Error initializing driver: {error.message()}");
                return -1;
            }
            Console.WriteLine($"Successfully initialize driver");
        }

        // Set driver
        inferenceReg.setDriver(driver);

        return 0;
    }
}