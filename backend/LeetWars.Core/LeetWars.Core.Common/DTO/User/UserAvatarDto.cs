namespace LeetWars.Core.Common.DTO.User;

public class UserAvatarDto
{
    public string ImagePath { get; set; }
    
    public UserAvatarDto(string imagePath)
    {
        ImagePath = imagePath;
    }
}