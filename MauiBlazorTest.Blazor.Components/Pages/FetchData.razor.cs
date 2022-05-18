using System.Net.Http.Json;
using MauiBlazorTest.Blazor.Components.Dev;
using MauiBlazorTest.Blazor.Shared;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class FetchDataVM : PageVMBase
{
    internal WeatherForecast[] Forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var httpC = HttpClientFactory.CreateClient("Api");
        Forecasts = await httpC.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}