namespace LeetWars.Core.DAL.Entities;

public class UserBadge : AuditEntity<long>
{
    public long UserId { get; set; }

    public long BadgeId { get; set; }

    public User? User { get; set; }

    public Badge? Badge { get; set; }

    public UserBadge(long userId, long badgeId)
    {
        UserId = userId;
        BadgeId = badgeId;
    }
}