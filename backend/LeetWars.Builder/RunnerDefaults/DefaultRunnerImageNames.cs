namespace LeetWars.Builder.RunnerDefaults
{
    public static class DefaultRunnerImageNames
    {
        //Images can be built with docker-compose -f docker-compose.code-runners.yml build from the app's root folder

        public const string CSharpImage = "csharpcoderunner";

        public const string CSharpTestImage = "csharptestrunner1";

        public const string CSharpBuildImage = "csharpcodebuilder";

        public const string JSImage = "jscoderunner";
    }

    public static class CSharpFileNaming
    {
        public const string SolutionFileName = "Solution.cs";

        public const string SolutionTestFileName = "Tests.cs";

        public const string TestResultsFileName = "testresults.trx";

        public const string BuildErrorResultsFileName = "errbuildoutput.txt";
    }
}
