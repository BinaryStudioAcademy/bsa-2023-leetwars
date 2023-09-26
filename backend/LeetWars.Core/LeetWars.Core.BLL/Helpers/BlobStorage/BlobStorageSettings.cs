namespace LeetWars.Core.BLL.Helpers.BlobStorage;

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