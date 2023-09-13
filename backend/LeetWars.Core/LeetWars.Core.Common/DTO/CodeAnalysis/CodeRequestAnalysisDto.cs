using Microsoft.AspNetCore.Http;
using System.Reflection;

namespace LeetWars.Core.Common.DTO.CodeAnalysis
{
    public class CodeRequestAnalysisDto
    {
        public string LanguageName { get; set; } = string.Empty;

        public string CodeListing { get; set; } = string.Empty;
    }
}
