using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace LeetWars.Core.WebAPI.Settings;

public class BlobStorageSettings
{
    public const string Storage = "Storage";
    
    public readonly string BlobUrl;
    
    public readonly string BlobContainerName;

    public readonly string BlobAccess;

    public BlobStorageSettings(string blobUrl, string blobContainerName, string blobAccess)
    {
        BlobUrl = blobUrl;
        BlobContainerName = blobContainerName;
        BlobAccess = blobAccess;
    }
}