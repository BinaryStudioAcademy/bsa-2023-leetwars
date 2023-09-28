using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.Notifier.WebAPI.Models;

public class CodeSubmitResult
{
    public CodeRunResults CodeRunResult { get; set; }
    public CodeResponseAnalysisDto CodeAnalysisResult { get; set; }

    public CodeSubmitResult(CodeRunResults codeRunResult, CodeResponseAnalysisDto codeAnalysisResult)
    {
        CodeRunResult = codeRunResult;
        CodeAnalysisResult = codeAnalysisResult;
    }
}