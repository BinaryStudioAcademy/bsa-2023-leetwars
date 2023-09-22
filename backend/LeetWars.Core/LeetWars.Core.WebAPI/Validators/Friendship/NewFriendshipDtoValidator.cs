using FluentValidation;
using LeetWars.Core.Common.DTO.Friendship;

namespace LeetWars.Core.WebAPI.Validators.Friendship
{
    public class NewFriendshipDtoValidator : AbstractValidator<NewFriendshipDto>
    {
        public NewFriendshipDtoValidator() 
        {
            RuleFor(dto => dto.SenderId)
               .NotEmpty().WithMessage("SenderId is required")
               .GreaterThan(0).WithMessage("SenderId must be greater than 0");

            RuleFor(dto => dto.RecipientId)
                .NotEmpty().WithMessage("RecipientId is required")
                .GreaterThan(0).WithMessage("RecipientId must be greater than 0");

            RuleFor(dto => dto)
                .Must(dto => dto.SenderId != dto.RecipientId)
                .WithMessage("SenderId cannot be the same as RecipientId");
        }
    }
}
