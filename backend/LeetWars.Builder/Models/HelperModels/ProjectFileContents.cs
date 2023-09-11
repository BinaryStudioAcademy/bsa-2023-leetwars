namespace LeetWars.Builder.Models.HelperModels;

public static class ProjectFileContents
{
    public static string CSharpProgramContent { get; } = "internal class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        Console.WriteLine(\"Hello, World!\");\r\n    }\r\n}";
    public static string CSharpProjectContent { get; } = "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <OutputType>Exe</OutputType>\r\n    <TargetFramework>net6.0</TargetFramework>\r\n    <ImplicitUsings>enable</ImplicitUsings>\r\n    <Nullable>enable</Nullable>\r\n  </PropertyGroup>\r\n\r\n</Project>\r\n";
}
