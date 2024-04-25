using System.ComponentModel;
using Microsoft.SemanticKernel;

public class AlertsPlugin
{
    [KernelFunction, Description("Somebody dies!")]
    public void DiedAlert()
    {
        Console.WriteLine("SOMEBODY DIES!");
    }

    //[KernelFunction, Description("A type of drink is declared a winner.")]
    //public void DrinkAlert([Description("The type of drink.")] string drinkType)
    //{
    //    Console.WriteLine("{drinkType} CHEERS!", drinkType);
    //}

    [KernelFunction, Description("Somebody is taking actions which puts a life in danger!")]
    public void DangerAlert()
    {
        Console.WriteLine("IMMINENT DANGER!");
    }

    //[KernelFunction, Description("The word 'rum' was mentioned in the last message.")]
    //public void RumAlert()
    //{
    //    Console.WriteLine("RUM ALERT!");
    //}

    //[KernelFunction, Description("The word 'force' was mentioned in the last message.")]
    //public void ForceAlert()
    //{
    //    Console.WriteLine("FORCE ALERT!");
    //}

    //[KernelFunction, Description("The word 'coca-cola' was mentioned in the last message.")]
    //public void CocaColaAlert()
    //{
    //    Console.WriteLine("COCA-COLA ALERT!");
    //}
}
