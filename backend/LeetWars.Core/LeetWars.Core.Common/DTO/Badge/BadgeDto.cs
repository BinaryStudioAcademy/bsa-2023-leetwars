using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Badge;

public class BadgeDto  : AuditEntity<long>
{
    public string? Name { get; set; }
    
    public string? Icon { get; set; }
    
    public string? IconGif { get; set; }
}