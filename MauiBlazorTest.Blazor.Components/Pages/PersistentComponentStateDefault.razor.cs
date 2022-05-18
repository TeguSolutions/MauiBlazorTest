using MauiBlazorTest.Blazor.Components.Dev;
using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class PersistentComponentStateDefaultVM : PageVMBase
{
    [Inject]
    protected PersistentComponentState ApplicationState { get; set; }
}