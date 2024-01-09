using System.Text.Json;
using Microsoft.JSInterop;

namespace BlazorOnGithub.Services;

public class JSMemoryService : IMemoryService
{
    private readonly IJSRuntime _jsRuntime;

    public JSMemoryService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<T?> GetItemAsync<T>(string key)
    {
        var value = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        if (!string.IsNullOrWhiteSpace(value))
        {
            return JsonSerializer.Deserialize<T>(value);
        }

        return default;
    }

    public async Task SetItemAsync<T>(string key, T value)
    {
        var item = JsonSerializer.Serialize(value);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, item);
    }
}