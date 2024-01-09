namespace BlazorOnGithub.Services;

public interface IMemoryService
{
    public Task<T?> GetItemAsync<T>(string key);

    public Task SetItemAsync<T>(string key, T value);
}