namespace LeetWars.Core.Common.Exceptions
{
    public class BadOperationException : Exception
    {
        public BadOperationException(string message) : base(message) { }

        public BadOperationException() : base("Invalid operation") { }
    }
}
