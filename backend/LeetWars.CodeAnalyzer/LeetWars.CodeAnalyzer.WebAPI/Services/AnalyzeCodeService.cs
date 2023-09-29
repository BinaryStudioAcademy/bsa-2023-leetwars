using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.BLL.Exceptions;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using System.Globalization;

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
                ?? throw new NotFoundException(nameof(CodeRequestAnalysisDto));

            string response = chatResponse.ToString();

            if (string.IsNullOrWhiteSpace(response))
            {
                throw new NotFoundException(nameof(CodeRequestAnalysisDto));
            }

            if (int.TryParse(response, NumberStyles.Integer, CultureInfo.InvariantCulture, out int qualityMark))
            {
                return new CodeResponseAnalysisDto
                {
                    QualityMark = qualityMark
                };
            }

            return new CodeResponseAnalysisDto { QualityMark = 50 };
        }
    }
}
