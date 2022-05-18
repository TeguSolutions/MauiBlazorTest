using MauiBlazorTest.Blazor.Shared.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MauiBlazorTest.Blazor.Server.ServiceImplementations
{
    public class BlazorPersistentComponentState : IPersistentComponentState
    {
        private readonly PersistentComponentState pcs;

        public BlazorPersistentComponentState(PersistentComponentState persistentComponentState)
        {
            this.pcs = persistentComponentState;
        }

        public void PersistAsJson<T>(string key, T instance)
        {
            pcs.PersistAsJson(key, instance);
        }

        public void RegisterOnPersisting(Func<Task> callback)
        {
            pcs.RegisterOnPersisting(callback);
        }

        public bool TryTakeFromJson<T>(string key, out T instance)
        {
            return pcs.TryTakeFromJson(key, out instance);
        }
    }
}
