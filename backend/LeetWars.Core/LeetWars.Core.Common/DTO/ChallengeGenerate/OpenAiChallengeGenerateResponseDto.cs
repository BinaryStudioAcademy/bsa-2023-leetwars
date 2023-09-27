using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.ChallengeGenerate
{
    public class OpenAiChallengeGenerateResponseDto
    {
        public string Description { get; set; } = string.Empty;
        public string CompleteSolution { get; set; } = string.Empty;
        public string InitialSolution { get; set; } = string.Empty;
        public string Tests { get; set; } = string.Empty;
        public string TestsSubset { get; set; } = string.Empty;
    }
}
