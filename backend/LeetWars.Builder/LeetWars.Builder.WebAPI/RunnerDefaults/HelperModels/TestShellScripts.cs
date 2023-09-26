namespace LeetWars.Builder.RunnerDefaults.HelperModels;

public static class TestShellScripts
{
    public const string CSharpTestScript = "cp /LocalVolume/Solution.cs ./Solution.cs\ncp /LocalVolume/Tests.cs ./Test.cs\ncp /LocalVolume/Preloaded.cs ./Preloaded.cs\ndotnet test --logger \"trx;LogFileName=testresults.trx\" --results-directory \"/LocalVolume\"";

    public const string JSTestScript = "cp /LocalVolume/code.js /app/code.js\nnpm test";
}
