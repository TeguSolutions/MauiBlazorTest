using MauiBlazorTest.Blazor.Components.Dev;
using MauiBlazorTest.Blazor.Shared.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class PersistentComponentStateFix2VM : PageVMBase
{
    [Inject]
    protected IPersistentComponentState PersistentComponentState { get; set; } 
}