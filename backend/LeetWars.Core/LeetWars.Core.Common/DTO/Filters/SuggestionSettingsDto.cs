namespace LeetWars.Core.Common.DTO.Filters;

public interface SuggestionSettingsDto
{
    public int LanguageId { get; set; }
    public SuggestionType SuggestionType { get; set; }
}