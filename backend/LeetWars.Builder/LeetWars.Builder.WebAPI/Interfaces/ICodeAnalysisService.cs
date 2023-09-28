using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.Builder.Interfaces;

public interface ICodeAnalysisService
{
     Task<CodeResponseAnalysisDto?> RunCodeAnalysisAsync(CodeRequestAnalysisDto codeRequestAnalysisDto);
}