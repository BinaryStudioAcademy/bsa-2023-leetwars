using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.CodeAnalysis;

namespace LeetWars.CodeAnalyzer.Services
{
    public class AnalyzeCodeService : IAnalyzeCodeService
    {
        private readonly IOpenAiSettings _openAiSettings;
        private readonly ICompletionService _completionService;

        public AnalyzeCodeService(IOpenAiSettings openAiSettings, ICompletionService completionService)
        {
            _openAiSettings = openAiSettings;
            _completionService = completionService;
        }

        public async Task<CodeResponseAnalysisDto> RunCodeAnalysisAsync(CodeRequestAnalysisDto requestDto)
        {
            string prompt = _openAiSettings.GetCodeAnalysisPrompt(requestDto.LanguageName, requestDto.CodeListing);

            var chatResponse = await _completionService.CreateCompletionAsync(prompt)
                ?? throw new ArgumentException(nameof(requestDto));

            string response = chatResponse.ToString();

            if(string.IsNullOrWhiteSpace(response))
            {
                throw new ArgumentException(nameof(requestDto));
            }

            int qualityMark = int.Parse(response);

            return new CodeResponseAnalysisDto
            {
                QualityMark = qualityMark
            };
        }
    }
}
