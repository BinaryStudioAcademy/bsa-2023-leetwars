using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Extensions;

public static class LanguageLevelExtension
{
    public static LanguageLevel GetNextLevel(this LanguageLevel source)
    {

        if (source == LanguageLevel.Extreme)
        {
            return source;
        }

        var levelIndex = (int)source + 1;
        return (LanguageLevel)levelIndex;
    }
}