using System.ComponentModel;
using Microsoft.SemanticKernel;

public class AlertsPlugin
{
    [KernelFunction, Description("Somebody is going to die.")]
    public void DiedAlert([Description("The name of the person who is going to die.")] string agentName)
    {
        Console.WriteLine($"{agentName} WILL DIE!");
    }

    [KernelFunction, Description("Somebody is being sarcastic.")]
    public void SarcasmAlert([Description("The name of the person who is getting sarcastic.")] string agentName)
    {
        Console.WriteLine($"{agentName} BECOMES SARCASTIC!");
    }

    [KernelFunction, Description("Somebody is taking actions which puts a life in danger.")]
    public void DangerAlert([Description("The name of the person who is producing an imminent danger.")] string agentName)
    {
        Console.WriteLine($"{agentName} IS PRODUCING IMMINENT DANGER!");
    }

    [KernelFunction, Description("Somebody said the word 'rum'.")]
    public void RumAlert([Description("The name of the person who said the word 'rum'.")] string agentName)
    {
        Console.WriteLine($"{agentName} IS TRIGGERING RUM ALERT!");
    }
}
