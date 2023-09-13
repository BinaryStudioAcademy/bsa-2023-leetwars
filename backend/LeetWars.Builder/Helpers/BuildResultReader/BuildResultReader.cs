using LeetWars.Builder.Models;
using LeetWars.Builder.Models.HelperModels;

namespace LeetWars.Builder.Helpers.BuildResultReader;

public class BuildResultReader
{
    private static void BuildResultCSharp(string buildlog, CodeRunResults result)
    {
        if(buildlog.Contains("Build FAILED"))
        {
            result.BuildResults = new BuildResult { IsSuccess = false, BuildMessage = buildlog };
        }
        else
        {
            result.BuildResults = new BuildResult { IsSuccess = true, BuildMessage = "Build was successful" };
        }
    }

    private static void BuildResultJS(string buildlog, CodeRunResults result)
    {
        if (buildlog.Contains("Error"))
        {
            result.BuildResults = new BuildResult { IsSuccess = false, BuildMessage = buildlog };
        }
        else
        {
            result.BuildResults = new BuildResult { IsSuccess = true, BuildMessage = "Build was successful" };
        }
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
