namespace LeetWars.Core.Common.DTO.CodeAnalysis
{
    public class CodeRequestAnalysisDto
    {
        public string LanguageName { get; set; }

        public string CodeListing { get; set; }

        public CodeRequestAnalysisDto(string languageName, string codeListing)
        {
            LanguageName = languageName;
            CodeListing = codeListing;
        }
    }
}
