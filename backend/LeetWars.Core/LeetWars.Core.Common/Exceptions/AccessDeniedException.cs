namespace LeetWars.Core.BLL.Exceptions
{
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException() : base("Access denied. You don't have permission to do it.") {}
    }
}
