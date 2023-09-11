namespace LeetWars.Builder.Models.HelperModels;

public static class Languages
{
    public const string csharp = "C#";
    public const string javascript = "Javascript";
    public static List<string> AvailableLanguages { get; } = new List<string>
    {
        csharp,
        javascript
    };
}
