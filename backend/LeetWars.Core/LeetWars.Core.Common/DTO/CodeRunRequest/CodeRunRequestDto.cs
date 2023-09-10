using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.CodeRunRequest;
public class CodeRunRequestDto
{
    public long UserId { get; set; }
    public long ChallengeVersionId { get; set; }
    public string Language { get; set; } = string.Empty;
    public string UserCode { get; set; } = string.Empty;

    public string? Preloaded { get; set; }
    public string? Tests { get; set; }
}