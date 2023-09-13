using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface IAnalyzeCodeService
    {
        Task<CodeResponseAnalysisDto> RunCodeAnalysis(CodeRequestAnalysisDto requestDto);
    }
}
