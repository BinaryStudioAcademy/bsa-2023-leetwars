using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.User
{
    public  class BriefUserInfoDto : Entity<long>
    {
        public string UserName { get; set; } = String.Empty;
    }
}
