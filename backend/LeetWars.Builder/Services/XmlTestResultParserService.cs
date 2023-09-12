using LeetWars.Builder.DTO;
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
            var xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(xmlTestResult);

            var nsManager = new XmlNamespaceManager(xmlDoc.NameTable);

            if (xmlDoc.DocumentElement?.NamespaceURI != null)
            {
                nsManager.AddNamespace("ns", xmlDoc.DocumentElement.NamespaceURI);
            }

            var mainNodes = GetMainNUnitNodes(xmlDoc, nsManager);

            CheckForNoNulls(mainNodes);

            var overallResultsAsStrings = GetOverallNUnitTestResult(mainNodes);

            CheckForNoNulls(overallResultsAsStrings);

            ICollection<Test> tests = new List<Test>();

            foreach (XmlNode testNode in mainNodes.UnitTestResultNodes!)
            {
                tests.Add(ParseSingleCSharpTest(testNode, nsManager));
            }

            var totalTimeString = CountExecutionTime(overallResultsAsStrings.StartTime!, overallResultsAsStrings.FinishTime!);

            var testResult = new TestsOutput(overallResultsAsStrings.Outcome == "Passed", totalTimeString, tests, int.Parse(overallResultsAsStrings.FailedCount!), int.Parse(overallResultsAsStrings.PassedCount!));

            return testResult;
        }

        public TestsOutput ParseJSTestResult(string xmlTestResult)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(xmlTestResult);

            XmlNode? testSuits = xmlDoc.SelectSingleNode("//testsuites") ?? throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");

            var overallResultsAsStrings = GetOverallMochaResults(testSuits);

            CheckForNoNulls(overallResultsAsStrings);

            int failedTestCount = int.Parse(overallResultsAsStrings.FailedCount!);

            int passed = int.Parse(overallResultsAsStrings.TestsCount!) - failedTestCount;

            XmlNodeList? testNodes = xmlDoc.SelectNodes("//testcase") ?? throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");

            ICollection<Test> tests = new List<Test>();

            foreach (XmlNode testNode in testNodes)
            {
                tests.Add(ParseSingleJSTest(testNode));
            }

            return new TestsOutput(failedTestCount == 0, overallResultsAsStrings.Duration!, tests, failedTestCount, passed);
        }

        private static Test ParseSingleCSharpTest(XmlNode testNode, XmlNamespaceManager nsManager)
        {
            var singleTestResult = GetSingleNUnitTestResult(testNode);

            CheckForNoNulls(singleTestResult);

            var testData = new Test(singleTestResult.TestName!, singleTestResult.Outcome == "Passed", singleTestResult.Duration!);

            if (singleTestResult.Outcome == "Failed")
            {
                XmlNode? errorMessageNode = testNode.SelectSingleNode("ns:Output/ns:ErrorInfo/ns:Message", nsManager);

                XmlNode? errorStackTraceNode = testNode.SelectSingleNode("ns:Output/ns:ErrorInfo/ns:StackTrace", nsManager);

                testData.ErrorMessage = (errorMessageNode?.InnerText.Trim() ?? string.Empty) + Environment.NewLine + (errorStackTraceNode?.InnerText.Trim() ?? string.Empty);
            }

            return testData;

        }

        private static NUnitTestResultsDto GetSingleNUnitTestResult(XmlNode testNode)
        {
            string? executionTime = testNode.Attributes?["duration"]?.Value;

            string? testName = testNode.Attributes?["testName"]?.Value;

            string? testOutcome = testNode.Attributes?["outcome"]?.Value;

            return new NUnitTestResultsDto
            {
                Duration = executionTime,
                TestName = testName,
                Outcome = testOutcome
            };
        }

        private static Test ParseSingleJSTest(XmlNode testNode)
        {
            var singleTestResult = GetSingleMochsTestResult(testNode);

            CheckForNoNulls(singleTestResult);

            XmlNode? failureNode = testNode.SelectSingleNode("failure");

            var testData = new Test(singleTestResult.Name!, failureNode == null, singleTestResult.Time!);

            if (failureNode != null)
            {
                string? failureMessage = failureNode.Attributes?["message"]?.Value;

                string? failureType = failureNode.Attributes?["type"]?.Value;

                string cdataSection = failureNode.InnerText;

                string stackTrace = cdataSection.Trim();

                testData.ErrorMessage = failureType + ": " + failureMessage + Environment.NewLine + stackTrace;
            }

            return testData;
        }

        private static MochaTestResultsDto GetSingleMochsTestResult(XmlNode testNode)
        {
            string? name = testNode.Attributes?["name"]?.Value;

            string? time = testNode.Attributes?["time"]?.Value;

            return new MochaTestResultsDto
            {
                Name = name,
                Time = time
            };
        }

        private static NUnitMainNodesDto GetMainNUnitNodes(XmlDocument xmlDoc, XmlNamespaceManager nsManager)
        {
            XmlNode? countersNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:ResultSummary/ns:Counters", nsManager);

            XmlNode? resultSummaryNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:ResultSummary", nsManager);

            XmlNode? timeNode = xmlDoc.SelectSingleNode("/ns:TestRun/ns:Times", nsManager);

            XmlNodeList? unitTestResultNodes = xmlDoc.SelectNodes("/ns:TestRun/ns:Results/ns:UnitTestResult", nsManager);


            return new NUnitMainNodesDto
            {
                Counters = countersNode,
                ResultSummary = resultSummaryNode,
                Times = timeNode,
                UnitTestResultNodes = unitTestResultNodes
            };
        }

        private static NUnitOverallResultsDto GetOverallNUnitTestResult(NUnitMainNodesDto mainNodes)
        {
            string? passed = mainNodes.Counters?.Attributes?["passed"]?.Value;

            string? failed = mainNodes.Counters?.Attributes?["failed"]?.Value;

            string? outcome = mainNodes.ResultSummary?.Attributes?["outcome"]?.Value;

            string? startTimeString = mainNodes.Times?.Attributes?["start"]?.Value;

            string? finishTimeString = mainNodes.Times?.Attributes?["finish"]?.Value;

            return new NUnitOverallResultsDto
            {
                Outcome = outcome,
                FailedCount = failed,
                PassedCount = passed,
                StartTime = startTimeString,
                FinishTime = finishTimeString
            };
        }

        private static MochaOverallResultsDto GetOverallMochaResults(XmlNode? testSuits)
        {
            string? duration = testSuits?.Attributes?["time"]?.Value;

            string? testsCount = testSuits?.Attributes?["tests"]?.Value;

            string? failed = testSuits?.Attributes?["failures"]?.Value;

            return new MochaOverallResultsDto
            {
                Duration = duration,
                TestsCount = testsCount,
                FailedCount = failed
            };
        }

        private static string CountExecutionTime(string startTimeString, string finishTimeString)
        {
            DateTime startTime = DateTime.Parse(startTimeString, CultureInfo.InvariantCulture);

            DateTime finishTime = DateTime.Parse(finishTimeString, CultureInfo.InvariantCulture);

            TimeSpan totalTime = finishTime - startTime;

            return totalTime.ToString();
        }

        private static void CheckForNoNulls(object obj)
        {
            if (!obj.GetType().GetProperties().ToList().TrueForAll(p => p != null))
            {
                throw new ArgumentException("Incorrect xml test file supplied, cannot find needed data");
            }
        }
    }
}
