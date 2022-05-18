using System.Diagnostics.CodeAnalysis;

namespace MauiBlazorTest.Blazor.Shared.Interfaces;

public interface IPersistentComponentState
{
    void PersistAsJson<T>(string key, T instance);
    void RegisterOnPersisting(Func<Task> callback);
    bool TryTakeFromJson<T>(string key, [MaybeNullWhen(false)] out T instance);
}