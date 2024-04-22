public static class PrintHelper
{
    public static void PrintAllPluginFunctions(Kernel kernel)
    {
        var functions = kernel.Plugins.GetFunctionsMetadata();

        Console.WriteLine("****** Registered 🔌 Plugins and 📦 Functions ******");

        foreach (KernelFunctionMetadata func in functions)
        {
            PrintPluginFunction(func);
        }
    }

    public static void PrintPluginFunction(KernelFunctionMetadata func)
    {
        Console.WriteLine($"🔌 {func.PluginName}");
        Console.WriteLine($"   📦 /{func.Name}: {func.Description}");

        if (func.Parameters.Count > 0)
        {
            Console.WriteLine("      📥 Params:");
            foreach (var p in func.Parameters)
            {
                Console.WriteLine($"       • {p.Name}: {p.Description} (default: '{p.DefaultValue}')");
            }
        }
    }

    public static async Task PrintRenderedPromptAsync(Kernel kernel, string promptTemplate, KernelArguments kernelArguments)
    {
        var promptTemplateFactory = new KernelPromptTemplateFactory();
        var promptTemplateRenderer = promptTemplateFactory.Create(new PromptTemplateConfig(promptTemplate));
        var renderedPrompt = await promptTemplateRenderer.RenderAsync(kernel, kernelArguments);
        
        Console.WriteLine(renderedPrompt);
    }
}
