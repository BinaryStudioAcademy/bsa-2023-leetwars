namespace LeetWars.Core.BLL.Exceptions
{
    public class InvalidUsernameOrPasswordException : Exception
    {
        public InvalidUsernameOrPasswordException() : base("Invalid username or password.") { }

        public InvalidUsernameOrPasswordException(string message) : base(message) { }
    }
}
