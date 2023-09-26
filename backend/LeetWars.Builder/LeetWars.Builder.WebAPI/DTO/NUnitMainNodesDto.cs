using System.Xml;

namespace LeetWars.Builder.DTO
{
    public class NUnitMainNodesDto
    {
        public XmlNode? Counters { get; set; }
        public XmlNode? ResultSummary { get; set; }
        public XmlNode? Times { get; set; }
        public XmlNodeList? UnitTestResultNodes { get; set; }
    }
}
