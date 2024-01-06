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
    public int Counter { get;set; } = 1;


    public event Action? AppStateChanged;
}