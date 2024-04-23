using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;

public static class Settings
{
    public static Kernel InitializeKernel()
    {
        var kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                deploymentName: "your deployment",
                endpoint: "your endpoint",
                apiKey: "your key")
        .Build();

        return kernel;
    }

    
    public static Kernel InitializeKernelWithVision()
    {
#pragma warning disable SKEXP0010
        var kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                deploymentName: "your deployment",
                endpoint: "your endpoint",
                apiKey: "your key")
            .AddOpenAITextToImage(apiKey: "your key") 
        .Build();

        return kernel;
#pragma warning restore SKEXP0010
    }
}
