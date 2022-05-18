using System.Net.Http.Json;
using MauiBlazorTest.Blazor.Components.Dev;
using MauiBlazorTest.Blazor.Shared;
using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class FetchDataVM : PageVMBase
{
    //[Inject]
    //protected PersistentComponentState ApplicationState { get; set; }


    internal WeatherForecast[] Forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var httpC = HttpClientFactory.CreateClient("Api");
        Forecasts = await httpC.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}