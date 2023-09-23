using AutoMapper;
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
    {
        return string.IsNullOrEmpty(source) ? null! : $"{_blobStorageSettings.BlobAccess}{source}";
    }
}