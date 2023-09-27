using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class UserCodeFightDto
    {
        public long SenderId { get; set; }
        public long ReceiverId { get; set; }
        public CodeFightStatus Status { get; set; }
    }
}
