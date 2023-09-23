using LeetWars.Core.DAL.Interfaces;

namespace LeetWars.Core.DAL.Providers
{
    public class UidProvider : IUidProvider
    {
        public string? Uid { get; private set; }

        public void SetUserUid(string? uid)
        {
            Uid = uid;
        }
    }
}
