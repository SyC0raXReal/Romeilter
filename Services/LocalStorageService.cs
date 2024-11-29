using System.Text.Json;
using Microsoft.JSInterop;

namespace Romeilter.Services;

public class LocalStorageService
{
    private readonly IJSRuntime _jsRuntime;

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }


    public async Task SetItem<T>(string key, T value)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
    }

    public async Task RemoveItem(string key)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
    }

    public async Task<T?> GetItem<T>(string key)
    {
        var value = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        return string.IsNullOrEmpty(value) ? default : JsonSerializer.Deserialize<T>(value);
    }
}