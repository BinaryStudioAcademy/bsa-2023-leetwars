using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Extensions;

public static class LanguageLevelExtension
{
    public static LanguageLevel GetNextLevel(this LanguageLevel source)
    {
        LanguageLevel[] allLevels = (LanguageLevel[])Enum.GetValues(typeof(LanguageLevel));

        int levelIndex = Array.IndexOf(allLevels, source);

        if (levelIndex >= 0 && levelIndex < allLevels.Length - 1)
        {
            LanguageLevel nextLevel = allLevels[levelIndex + 1];
            return nextLevel;
        }
        else
        {
            return source;
        }
    }  
}