using LeetWars.Builder.Models;
using System.Xml;

namespace LeetWars.Builder.Services
{
    public static class XmlTestResultParserService
    {
        public static CSharpTestOutput ParseCSharpTestResult(string xmlTestResult)
        {
            XmlDocument doc = new();

            doc.LoadXml(xmlTestResult);

            XmlNamespaceManager nsManager = new (doc.NameTable);

            nsManager.AddNamespace("ns", "http://microsoft.com/schemas/VisualStudio/TeamTest/2010");

            XmlNode? countersNode = doc.SelectSingleNode("/ns:TestRun/ns:ResultSummary/ns:Counters", nsManager);

            XmlNode? resultSummaryNode = doc.SelectSingleNode("/ns:TestRun/ns:ResultSummary", nsManager);

            XmlNode? startTimeNode = doc.SelectSingleNode("/ns:TestRun/ns:Times", nsManager);

            XmlNodeList? unitTestResultNodes = doc.SelectNodes("/ns:TestRun/ns:Results/ns:UnitTestResult", nsManager);

            if (countersNode == null || resultSummaryNode == null || startTimeNode == null) throw new ArgumentException("Inappropriate test data input");


            // Extract the attributes
            string? passed = countersNode.Attributes?["passed"]?.Value;

            string? failed = countersNode.Attributes?["failed"]?.Value;

            string? outcome = resultSummaryNode.Attributes?["outcome"]?.Value;

            string? startTimeString = startTimeNode.Attributes?["start"]?.Value;

            string? finishTimeString = startTimeNode.Attributes?["finish"]?.Value;

            if (passed == null || failed == null || outcome == null || startTimeString == null || finishTimeString == null || unitTestResultNodes == null) throw new ArgumentException("Inappropriate test data input, cannot find needed data");

            ICollection<CSharpTest> tests = new List<CSharpTest>();

            foreach (XmlNode node in unitTestResultNodes)
            {
                string? executionTime = node.Attributes?["duration"]?.Value;
                string? testName = node.Attributes?["testName"]?.Value;
                string? testOutcome = node.Attributes?["outcome"]?.Value;

                if (executionTime == null || testName == null || testOutcome == null) throw new ArgumentException("Inappropriate test data input");

                // Extract the relevant information from the selected nodes and store it for later use.
                var testData = new CSharpTest(testName, testOutcome, executionTime);

                if (testOutcome == "Failed")
                {
                    XmlNode? errorMessageNode = node.SelectSingleNode("ns:Output/ns:ErrorInfo/ns:Message", nsManager);
                    testData.ErrorMessage = errorMessageNode?.InnerText.Trim() ?? string.Empty;
                }

                tests.Add(testData);
            }

            //Calculate total time that was neede tu run all testing procedure

            DateTime startTime = DateTime.Parse(startTimeString);
            DateTime finishTime = DateTime.Parse(finishTimeString);

            TimeSpan totalTime = finishTime - startTime;


            var testResult = new CSharpTestOutput(outcome, totalTime.ToString(), tests, failed, passed);

            return testResult;
        }

    }
}
