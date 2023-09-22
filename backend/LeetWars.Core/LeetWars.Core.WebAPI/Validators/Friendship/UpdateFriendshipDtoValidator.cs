using FluentValidation;
using LeetWars.Core.Common.DTO.Friendship;

namespace LeetWars.Core.WebAPI.Validators.Friendship
{
    public class UpdateFriendshipDtoValidator : AbstractValidator<UpdateFriendshipDto>
    {
        public UpdateFriendshipDtoValidator()
        {
            RuleFor(dto => dto.FriendshipId)
               .NotEmpty().WithMessage("FriendshipId is required")
               .GreaterThan(0).WithMessage("FriendshipId must be greater than 0");

            RuleFor(dto => dto.UserId)
                .NotEmpty().WithMessage("UserId is required")
                .GreaterThan(0).WithMessage("UserId must be greater than 0");

            RuleFor(dto => dto.FriendshipStatus)
                .NotEmpty().WithMessage("FriendshipStatus is required");
        }
    }
}
