using LeetWars.Core.Common.DTO.Tag;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface ITagService
    {
        Task<ICollection<TagDto>> GetAllTagsAsync();
    }
}
