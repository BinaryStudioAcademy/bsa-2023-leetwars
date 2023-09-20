using Microsoft.AspNetCore.Http;

namespace LeetWars.Core.Common.DTO.User;

public class UpdateUserInfoDto
{
    public string? Email { get; set; }
    
    public string? Username { get; set; }
}
