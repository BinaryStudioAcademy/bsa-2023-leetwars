using LeetWars.Builder.Models;

namespace LeetWars.Builder.Helpers.BuildResultReader;

public class BuildResultReader
{
    public void BuildResultCSharp(string buildlog, CodeRunResults result)
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

    public void BuildResultJS(string buildlog, CodeRunResults result)
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
}
