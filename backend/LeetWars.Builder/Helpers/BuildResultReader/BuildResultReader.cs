using LeetWars.Builder.Models;
using LeetWars.Builder.RunnerDefaults.HelperModels;

namespace LeetWars.Builder.Helpers.BuildResultReader;

public class BuildResultReader
{
    private static void BuildResultCSharp(string buildlog, CodeRunResults result)
    {
        result.BuildResults = buildlog.Contains("Build FAILED")
            ? new BuildResult { IsSuccess = false, BuildMessage = buildlog }
            : new BuildResult { IsSuccess = true, BuildMessage = "Build was successful" };
    }

    private static void BuildResultJS(string buildlog, CodeRunResults result)
    {
        result.BuildResults = buildlog.Contains("Error")
            ? new BuildResult { IsSuccess = false, BuildMessage = buildlog }
            : new BuildResult { IsSuccess = true, BuildMessage = "Build was successful" };
    }

    public void BuildResults(string buildlog, CodeRunResults result, string language)
    {
        switch (language)
        {
            case Languages.csharp:
                BuildResultCSharp(buildlog, result);
                break;

            case Languages.javascript:
                BuildResultJS(buildlog, result);
                break;

            default:
                break;
        }
    }
}
