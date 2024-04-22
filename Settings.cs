using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;

public static class Settings
{
    public static Kernel InitializeKernel()
    {
        var kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                deploymentName: "gpt-4-turbo",
                endpoint: "https://apexdemo.openai.azure.com/",
                apiKey: "f5d8a3a6f9fc4703aef8c56e2828ac16")
        .Build();

        return kernel;
    }

    
    public static Kernel InitializeKernelWithVision()
    {
#pragma warning disable SKEXP0010
        var kernel = Kernel.CreateBuilder()
            .AddAzureOpenAIChatCompletion(
                deploymentName: "gpt-4-vision-preview",
                endpoint: "https://apexdalle3.openai.azure.com/",
                apiKey: "e066ae2206cd44adad46eef2e9bb8449")
            .AddOpenAITextToImage(apiKey: "e066ae2206cd44adad46eef2e9bb8449") 
        .Build();

        return kernel;
#pragma warning restore SKEXP0010
    }
}
