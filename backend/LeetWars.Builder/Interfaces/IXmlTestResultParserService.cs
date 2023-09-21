using LeetWars.Builder.Models;

namespace LeetWars.Builder.Interfaces
{
    public interface IXmlTestResultParserService
    {
        TestsOutput ParseCSharpTestResult(string xmlTestResult);
        TestsOutput ParseJSTestResult(string xmlTestResult);
    }
}
