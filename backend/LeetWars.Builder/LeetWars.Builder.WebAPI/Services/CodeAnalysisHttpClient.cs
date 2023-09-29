using LeetWars.Builder.Interfaces;
using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.Builder.Services;

public class CodeAnalysisHttpClient: ICodeAnalysisService
{
    private readonly HttpClient _httpClient;
 
    public CodeAnalysisHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<CodeResponseAnalysisDto?> RunCodeAnalysisAsync(CodeRequestAnalysisDto codeRequestAnalysisDto)
    {
        var response = await _httpClient.PostAsJsonAsync("analyzeCode", codeRequestAnalysisDto);
        
        return await response.Content.ReadFromJsonAsync<CodeResponseAnalysisDto>();
    }
}