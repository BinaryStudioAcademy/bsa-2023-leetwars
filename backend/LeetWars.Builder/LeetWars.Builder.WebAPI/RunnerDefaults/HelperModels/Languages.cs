namespace LeetWars.Builder.RunnerDefaults.HelperModels;

public static class Languages
{
    public const string csharp = "csharp";
    public const string javascript = "Javascript";
    public static List<string> AvailableLanguages { get; } = new List<string>
    {
        csharp,
        javascript
    };
}
