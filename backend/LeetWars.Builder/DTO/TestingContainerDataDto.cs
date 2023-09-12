namespace LeetWars.Builder.DTO
{
    public class TestingContainerDataDto
    {
        public string ProcessName { get; set; }
        public string Language { get; set; }
        public string Code { get; set; }
        public string Tests { get; set; }
        public string Preloaded { get; set; }

        public TestingContainerDataDto(string processName, string language, string code, string tests, string preloaded = "") 
        { 
            ProcessName = processName;
            Language = language;
            Code = code;
            Tests = tests;
            Preloaded = preloaded;
        }

    }
}
