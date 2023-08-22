using LeetWars.Core.Common.DTO.Language;
using LeetWars.Core.Common.DTO.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.Interfaces
{
    public interface ILanguageService
    {
        Task<ICollection<LanguageDto>> GetAllLanguageAsync();

    }
}
