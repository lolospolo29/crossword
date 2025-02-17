using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages;
public partial class Counter : ComponentBase
{
    protected int CounterCount { get; set; } = 0;

    protected void IncrementCount()
    {
        CounterCount++;
    }
}
