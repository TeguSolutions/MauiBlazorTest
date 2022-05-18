using MauiBlazorTest.Blazor.Shared.Interfaces;

namespace MauiBlazorTest.Maui.ServiceImplementations;

public class MauiPersistentComponentState : IPersistentComponentState
{
    public void PersistAsJson<T>(string key, T instance)
    {
        // Do nothing, or something... just don't crash
    }

    public void RegisterOnPersisting(Func<Task> callback)
    {
        // Do nothing, or something... just don't crash
    }

    public bool TryTakeFromJson<T>(string key, out T instance)
    {
        // Do nothing, or something... just don't crash
        instance = default;
        return false;
    }
}