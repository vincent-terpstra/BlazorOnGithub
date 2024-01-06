using Microsoft.AspNetCore.Components;

namespace BlazorOnGithub.Services;

public class AppState
{
    public string Message { get; set; } = "Hello";
    public bool Enabled { get; set; } = true;
    public int Counter { get;set; } = 1;
}