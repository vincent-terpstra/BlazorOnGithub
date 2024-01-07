using Microsoft.AspNetCore.Components;

namespace BlazorOnGithub.Services;

public class AppState
{
    private string _message = "Hello";
    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            AppStateChanged?.Invoke();
        }
    }

    public bool Enabled { get; set; } = true;

    private int _count = 1;
    public int Count
    {
        get => _count;
        set
        {
            _count = value;
            AppStateChanged?.Invoke();
        }
    }
    
    public event Action? AppStateChanged;
}