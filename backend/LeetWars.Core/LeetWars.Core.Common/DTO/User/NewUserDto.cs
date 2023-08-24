using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public class NewUserDto
    {
        public Country Country { get; set; }
        public int Timezone { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string OAuthToken { get; set; } = string.Empty;
    }
}
