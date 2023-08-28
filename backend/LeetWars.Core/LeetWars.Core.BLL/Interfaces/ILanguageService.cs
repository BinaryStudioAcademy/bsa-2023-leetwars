using LeetWars.Core.Common.DTO.Language;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface ILanguageService
    {
        Task<ICollection<LanguageDto>> GetAllLanguageAsync();

    }
}
