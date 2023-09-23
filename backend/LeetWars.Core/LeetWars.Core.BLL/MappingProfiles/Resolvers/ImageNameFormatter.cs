using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.BLL.Services;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.User;
using LeetWars.Core.DAL.Entities;
using LeetWars.Core.WebAPI.Settings;

namespace LeetWars.Core.BLL.MappingProfiles.Resolvers;

public class ImageNameFormatter : IValueConverter<string, string> 
{
    private readonly BlobStorageSettings _blobStorageSettings;

    public ImageNameFormatter(BlobStorageSettings blobStorageSettings)
    {
        _blobStorageSettings = blobStorageSettings;
    }
    
    public string Convert(string source, ResolutionContext context)
        => string.IsNullOrEmpty(source) ? null! : $"{_blobStorageSettings.BlobAccess}{source}";
}