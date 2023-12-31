﻿using FluentValidation;
using LeetWars.Core.Common.DTO.User;
using System.Text.RegularExpressions;

namespace LeetWars.Core.WebAPI.Validators.User
{
    public class UserRegisterDtoValidator : AbstractValidator<NewUserDto>
    {
        public UserRegisterDtoValidator()
        {
            RuleFor(u => u.UserName)
                .NotEmpty()
                    .When(u => !u.IsWithProvider)
                    .WithMessage("UserName is required")
                .Length(2, 50)
                    .When(u => !u.IsWithProvider)
                    .WithMessage("The name must contain at least 2 and at most 50 characters.")
                .Must(BeValidLatinOrCyrillicCharacters)
                    .When(u => !u.IsWithProvider)
                    .WithMessage("Enter your name in Latin or Cyrillic");

            RuleFor(u => u.Email)
                .EmailAddress()
                .NotEmpty()
                    .WithMessage("Email is required")
                .MaximumLength(255)
                    .WithMessage("Email can't be longer than 255 characters.");
        }

        private bool BeValidLatinOrCyrillicCharacters(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName) && Regex.IsMatch(userName, Regaxes.RegexPatterns.LatinOrCyrillicCharactersPattern, RegexOptions.None, TimeSpan.FromMilliseconds(100));
        }
    }
}
