namespace LeetWars.Core.Common.Extensions
{
    public static class StringExtensions
    {
        public static string GetUserNameFromEmail(this string email)
        {
            int dogIndex = email.IndexOf("@");

            return email.Substring(0, dogIndex);
        }
    }
}
