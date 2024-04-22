using Microsoft.SemanticKernel;
using System.ComponentModel;

public class MotorPlugin
{
    [KernelFunction, Description("Moves the car backward.")]
    public void Backward()
    {
        Console.WriteLine(ToArrow("Backward"));
        // TODO call car motor API, backward endpoint
    }

    [KernelFunction, Description("Moves the car forward.")]
    public void Forward()
    {
        Console.WriteLine(ToArrow("Forward"));
        // TODO call car motor API, forward endpoint
    }

    [KernelFunction, Description("Stops the car.")]
    public void Stop()
    {
        Console.WriteLine(ToArrow("Stop"));
        // TODO call car motor API, stop endpoint
    }

    [KernelFunction, Description("Turns the car anticlockwise.")]
    public void TurnLeft()
    {
        Console.WriteLine(ToArrow("TurnLeft"));
        // TODO call car motor API, turn left endpoint
    }

    [KernelFunction, Description("Turns the car clockwise.")]
    public void TurnRight()
    {
        Console.WriteLine(ToArrow("TurnRight"));
        // TODO call car motor API, turn right endpoint
    }

    private string ToArrow(string function)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        var x = function.ToUpper() switch
        {
            "STOP" => "·",
            "FORWARD" => "🡲",
            "BACKWARD" => "🡰",
            "TURNLEFT" => "🡵",
            "TURNRIGHT" => "🡶",
            _ => "?"
        };

        return x;
    }    
}