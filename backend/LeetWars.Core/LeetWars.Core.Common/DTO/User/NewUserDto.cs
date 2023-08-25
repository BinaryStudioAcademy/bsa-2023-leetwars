using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public class NewUserDto
    {
        public string Uid { get; set; }
        public int Timezone { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? ImagePath { get; set; }
    }
}
