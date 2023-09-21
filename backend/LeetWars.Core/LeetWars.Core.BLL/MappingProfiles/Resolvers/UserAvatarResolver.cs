using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.WebAPI.Settings;

namespace LeetWars.Core.BLL.MappingProfiles.Resolvers;

public class UserAvatarResolver : IValueResolver<User, IDtoWithImage, string?>
{
    private readonly BlobStorageSettings _blobStorageSettings;

    public UserAvatarResolver(BlobStorageSettings blobStorageSettings)
    {
        _blobStorageSettings = blobStorageSettings;
    }
    
    public string Resolve(User source, IDtoWithImage destination, string? destMember, ResolutionContext context)
    {
        return string.IsNullOrEmpty(source.ImagePath) ? null! : $"{_blobStorageSettings.BlobAccess}{source.ImagePath}";
    }
}