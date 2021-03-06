using MauiBlazorTest.Blazor.Components.Dev;
using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Components.Pages;

public class PersistentComponentStateFix1VM : PageVMBase
{


    #region Lifecycle

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
    }

    #endregion

#if BLAZOR
    [Inject]
    protected PersistentComponentState ApplicationState { get; set; }

    public void Test()
    {
        ApplicationState.PersistAsJson("bla", "bla");
        ApplicationState.RegisterOnPersisting(async () => await DoNoting());
        ApplicationState.TryTakeFromJson("bla", out string instance);
    }

    private async Task DoNoting()
    {
        await Task.Delay(1);
    }
#endif


}