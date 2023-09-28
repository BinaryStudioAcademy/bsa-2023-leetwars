using FluentValidation;
using LeetWars.Core.Common.DTO.Challenge;

namespace LeetWars.Core.WebAPI.Validators.Challenge
{
    public class NewChallengeDtoValidator : AbstractValidator<NewChallengeDto>
    {
        public NewChallengeDtoValidator()
        {
            RuleForEach(dto => dto.Versions)
                .ChildRules(challengeVersion =>
                {
                    challengeVersion.RuleFor(cv => cv.ExampleTestCases)
                        .NotEmpty().WithMessage("ExampleTestCases are required!");

                    challengeVersion.RuleFor(cv => cv.InitialSolution)
                        .NotEmpty().WithMessage("InitialSolution is required!");

                    challengeVersion.RuleFor(cv => cv.TestCases)
                        .NotEmpty().WithMessage("TestCases are required!");

                    challengeVersion.RuleFor(cv => cv.CompleteSolution)
                        .NotEmpty().WithMessage("CompleteSolution is required!");
                });

            RuleFor(dto => dto.LevelId).NotEmpty().WithMessage("LevelId is required!");
            RuleFor(dto => dto.Tags).NotEmpty().WithMessage("Tags are required!");
            RuleFor(dto => dto.Title).NotEmpty().WithMessage("Title is required!");
            RuleFor(dto => dto.Instructions).NotEmpty().WithMessage("Instructions are required!");
        }
    }
}
