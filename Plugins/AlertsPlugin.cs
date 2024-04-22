using System.ComponentModel;
using Microsoft.SemanticKernel;
using Serilog;

namespace Apex.SemanticKernelAgents.Plugins;

public class AlertsPlugin
{
    [KernelFunction, Description("Somebody dies!")]
    public void DiedAlert()
    {
        Log.Information("SOMEBODY DIES!");
    }

    //[KernelFunction, Description("A type of drink is declared a winner.")]
    //public void DrinkAlert([Description("The type of drink.")] string drinkType)
    //{
    //    Log.Information("{drinkType} CHEERS!", drinkType);
    //}

    [KernelFunction, Description("Somebody is taking actions which puts a life in danger!")]
    public void DangerAlert()
    {
        Log.Information("IMMINENT DANGER!");
    }

    //[KernelFunction, Description("The word 'rum' was mentioned in the last message.")]
    //public void RumAlert()
    //{
    //    Log.Information("RUM ALERT!");
    //}

    //[KernelFunction, Description("The word 'force' was mentioned in the last message.")]
    //public void ForceAlert()
    //{
    //    Log.Information("FORCE ALERT!");
    //}

    //[KernelFunction, Description("The word 'coca-cola' was mentioned in the last message.")]
    //public void CocaColaAlert()
    //{
    //    Log.Information("COCA-COLA ALERT!");
    //}
}
