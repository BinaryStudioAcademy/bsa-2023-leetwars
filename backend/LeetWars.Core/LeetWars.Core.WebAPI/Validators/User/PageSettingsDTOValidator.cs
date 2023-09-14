using FluentValidation;
using LeetWars.Core.Common.DTO.Filters;
using LeetWars.Core.Common.DTO.User;

namespace LeetWars.Core.WebAPI.Validators.User
{
    public class PageSettingsDtoValidator : AbstractValidator<PageSettingsDto>
    {
        public PageSettingsDtoValidator()
        {
            RuleFor(p => p.PageNumber).GreaterThan(0).WithMessage("Page number must be greated than 0");

            RuleFor(p => p.PageSize).GreaterThan(0).WithMessage("Page size must be greated than 0");

        }
    }
}
