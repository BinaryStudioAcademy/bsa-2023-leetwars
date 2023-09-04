using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public class NewUserDto
    {
        public string Uid { get; set; } = string.Empty;
        public int Timezone { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? ImagePath { get; set; }
    }
}
