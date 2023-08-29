using FluentValidation;
using LeetWars.Core.Common.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetWars.Core.WebAPI.Validators.User
{
    public class UserRegisterDtoValidator : AbstractValidator<NewUserDto>
    {
        public UserRegisterDtoValidator()
        {
            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage("UserName is requeried")
                .Length(2, 50)
                    .WithMessage("The name must contain at least 2 and at most 50 characters.")
                .Must(BeValidLatinCharacters)
                  .WithMessage("Enter your name in Latin");

            RuleFor(u => u.Email)
                .EmailAddress()
                .NotEmpty()
                    .WithMessage("Email is requeried")
                .MaximumLength(255)
                    .WithMessage("Email can't be longer than 255 characters.");
        }

        private bool BeValidLatinCharacters(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName) && Regex.IsMatch(userName, "^[A-Za-z -]+$", RegexOptions.None, TimeSpan.FromMilliseconds(100));
        }
    }
}
