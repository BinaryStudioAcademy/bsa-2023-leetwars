using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace LeetWars.CodeAnalyzer.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyzeCodeController : ControllerBase
    {
        private readonly IAnalyzeCodeService _analyzeCodeService;

        public AnalyzeCodeController(IAnalyzeCodeService analyzeCodeService)
        {
            _analyzeCodeService = analyzeCodeService;
        }

        [HttpPost]
        public async Task<IActionResult> RunCodeAnalysisAsync(CodeRequestAnalysisDto requestDto)
        {
            var response = await _analyzeCodeService.RunCodeAnalysisAsync(requestDto);
            return Ok(response);
        }
    }
}
