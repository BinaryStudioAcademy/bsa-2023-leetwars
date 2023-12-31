﻿using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Filters;

public class SuggestionSettingsDto
{
    public long? LanguageId { get; set; }
    public SuggestionType SuggestionType { get; set; }
}