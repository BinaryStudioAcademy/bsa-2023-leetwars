namespace LeetWars.Builder.RunnerDefaults.HelperModels
{
    public static class DefaultRunnerImageNames
    {
        //Images can be built with docker-compose -f docker-compose.code-runners.yml build from the app's root folder

        public const string CSharpTestImage = "csharptestrunner";

        public const string CSharpBuildImage = "csharpcodebuilder";

        public const string JSTestImage = "jstestrunner";

        public const string JSBuildImage = "jscodebuilder";
    }
}
