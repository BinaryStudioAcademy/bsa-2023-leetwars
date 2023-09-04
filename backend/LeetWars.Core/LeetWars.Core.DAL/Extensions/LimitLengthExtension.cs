namespace LeetWars.Core.DAL.Extensions
{
    public static class LimitLengthExtension
    {
        public static string LimitLength(this string source, int maxLength)
        {
            if (source.Length <= maxLength)
            {
                return source;
            }

            return source.Substring(0, maxLength);
        }
    }
}
