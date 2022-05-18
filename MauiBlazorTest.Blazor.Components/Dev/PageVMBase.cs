using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Components.Dev;

public class PageVMBase : ComponentBase
{
    [Inject]
    protected NavigationManager NavM { get; set; }

    [Inject]
    protected IHttpClientFactory HttpClientFactory { get; set; }
}