namespace LeetWars.Core.DAL.Entities;

public class Badge : Entity<long>
{
    public string Name { get; set; }
    
    public string Icon { get; set; }
    
    public string IconGif { get; set; }
    
    public ICollection<UserBadge> BadgeUsers { get; } = new List<UserBadge>();

    public Badge(string name, string icon, string iconGif)
    {
        Name = name;
        Icon = icon;
        IconGif = iconGif;
    }
}