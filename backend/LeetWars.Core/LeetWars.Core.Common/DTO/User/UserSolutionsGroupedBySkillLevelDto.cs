using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO
{
    public class UserSolutionsGroupedBySkillLevelDto
    {
        public int TotalCount { get; set; }
        public LanguageLevel Name { get; set; }
        public IEnumerable<TaskCountDto>? TaskCountDtos { get; set; }

    }
}
