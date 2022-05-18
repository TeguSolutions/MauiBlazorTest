using MauiBlazorTest.Blazor.Components.Dev;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class CounterVM : PageVMBase
{
    internal int CurrentCount { get; set; }

    internal void IncrementCount()
    {
        CurrentCount++;
    }
}