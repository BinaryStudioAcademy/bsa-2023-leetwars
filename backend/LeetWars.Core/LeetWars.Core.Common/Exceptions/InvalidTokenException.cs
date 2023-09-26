namespace LeetWars.Core.Common.Exceptions
{
    public sealed class InvalidTokenException : Exception
    {
        public InvalidTokenException(string id) : base($"No token with user id {id} was passed") { }
    }
}
