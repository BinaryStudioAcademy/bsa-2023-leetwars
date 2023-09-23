namespace LeetWars.Core.DAL.Interfaces
{
    public interface IUidProvider
    {
        string? Uid { get; }
        void SetUserUid(string? uid);
    }
}
