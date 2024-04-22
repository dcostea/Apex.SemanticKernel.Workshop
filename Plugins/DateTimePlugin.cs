using System.ComponentModel;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Plugins.Core;

public class DateTimePlugin
{
    [KernelFunction, Description("Get the current date")]
    public string GetCurrentDate() => DateTime.Now.ToShortDateString();
}