namespace BlazorOnGithub.Pages.Images;

public static class ImagesExtensions
{
    public static string ToDataUrl(this MemoryStream data, string format)
    {
        var span = new Span<byte>(data.GetBuffer()).Slice(0, (int)data.Length);
        return $"data:{format};base64,{Convert.ToBase64String(span)}";
    }
}