using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using System.Globalization;
using System.Xml;

namespace LeetWars.Builder.Services
{
    public class XmlTestResultParserService : IXmlTestResultParserService
    {
        public TestsOutput ParseCSharpTestResult(string xmlTestResult)
        {
            XmlDocument xmlDoc = new();

            xmlDoc.LoadXml(xmlTestResult);

            XmlNamespaceManager nsManager = new (xmlDoc.NameTable);

            if(xmlDoc.DocumentElement?.NamespaceURI != null) nsManager.AddNamespace("ns", xmlDoc.DocumentElement.NamespaceURI);

            XmlNode? countersNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:ResultSummary/ns:Counters", nsManager);

            XmlNode? resultSummaryNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:ResultSummary", nsManager);

            XmlNode? startTimeNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:Times", nsManager);

            XmlNodeList? unitTestResultNodes = xmlDoc.SelectNodes("/ns:TestRun/ns:Results/ns:UnitTestResult", nsManager);

            if (countersNode == null || resultSummaryNode == null || startTimeNode == null)
            {
                throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
            }

            string? passed = countersNode.Attributes?["passed"]?.Value;

            string? failed = countersNode.Attributes?["failed"]?.Value;

            string? outcome = resultSummaryNode.Attributes?["outcome"]?.Value;

            string? startTimeString = startTimeNode.Attributes?["start"]?.Value;

            string? finishTimeString = startTimeNode.Attributes?["finish"]?.Value;

            if (passed == null || failed == null || outcome == null || startTimeString == null || finishTimeString == null || unitTestResultNodes == null)
            {
                throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
            }

            ICollection<Test> tests = new List<Test>();

            foreach (XmlNode node in unitTestResultNodes)
            {
                string? executionTime = node.Attributes?["duration"]?.Value;

                string? testName = node.Attributes?["testName"]?.Value;

                string? testOutcome = node.Attributes?["outcome"]?.Value;

                if (executionTime == null || testName == null || testOutcome == null)
                {
                    throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
                }

                var testData = new Test(testName, testOutcome == "Passed", executionTime);

                if (testOutcome == "Failed")
                {
                    XmlNode? errorMessageNode = node.SelectSingleNode("ns:Output/ns:ErrorInfo/ns:Message", nsManager);

                    XmlNode? errorStackTraceNode = node.SelectSingleNode("ns:Output/ns:ErrorInfo/ns:StackTrace", nsManager);

                    testData.ErrorMessage = (errorMessageNode?.InnerText.Trim() ?? string.Empty) + Environment.NewLine + (errorStackTraceNode?.InnerText.Trim() ?? string.Empty);
                }

                tests.Add(testData);
            }

            DateTime startTime = DateTime.Parse(startTimeString, CultureInfo.InvariantCulture);

            DateTime finishTime = DateTime.Parse(finishTimeString, CultureInfo.InvariantCulture);

            TimeSpan totalTime = finishTime - startTime;


            var testResult = new TestsOutput(outcome == "Passed", totalTime.ToString(), tests, int.Parse(failed), int.Parse(passed));

            return testResult;
        }

        public TestsOutput ParseJSTestResult(string xmlTestResult)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(xmlTestResult);

            XmlNode? testSuits = xmlDoc.SelectSingleNode("//testsuites") ?? throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");

            string? duration = testSuits.Attributes?["time"]?.Value;

            string? testsCount = testSuits.Attributes?["tests"]?.Value;

            string? failed = testSuits.Attributes?["failures"]?.Value;

            if(duration == null || testsCount == null || failed == null) 
            {
                throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
            }

            int passed = int.Parse(testsCount) - int.Parse(failed);

            XmlNodeList? testcaseNodes = xmlDoc.SelectNodes("//testcase") ?? throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");

            ICollection<Test> tests = new List<Test>();

            foreach (XmlNode testcaseNode in testcaseNodes) 
            {
                string? name = testcaseNode.Attributes?["name"]?.Value;

                string? time = testcaseNode.Attributes?["time"]?.Value;

                if(name == null || time == null) 
                {
                    throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
                }

                XmlNode? failureNode = testcaseNode.SelectSingleNode("failure");

                var testData = new Test(name, failureNode == null, duration);

                if (failureNode != null) 
                { 
                    string? failureMessage = failureNode.Attributes?["message"]?.Value;

                    string? failureType = failureNode.Attributes?["type"]?.Value;

                    string cdataSection = failureNode.InnerText;

                    string stackTrace = cdataSection.Trim();

                    testData.ErrorMessage = failureType + ": " + failureMessage + Environment.NewLine + stackTrace;
                }

                tests.Add(testData);
            }

            int failedTestCount = int.Parse(failed);

            return new TestsOutput( failedTestCount == 0, duration, tests, failedTestCount, passed);
        }
    }
}
