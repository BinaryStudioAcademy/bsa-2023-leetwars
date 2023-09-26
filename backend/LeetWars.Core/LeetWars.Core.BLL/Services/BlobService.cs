using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using LeetWars.Core.BLL.Interfaces;

namespace LeetWars.Core.BLL.Services;

public class BlobService : IBlobService
{
    private readonly BlobContainerClient _blobContainerClient;

    public BlobService(BlobContainerClient blobClient)
    {
        _blobContainerClient = blobClient;
    }

    public string GetBlob(string fileName)
    {
        var client = _blobContainerClient.GetBlobClient(fileName);

        return client.Uri.AbsoluteUri;
    }

    public async Task UploadFileBlobAsync(Stream stream, string contentType, string uniqueName)
    {
        var client = _blobContainerClient.GetBlobClient(uniqueName);
        var headers = new BlobHttpHeaders { ContentType = contentType };
        await client.UploadAsync(stream, headers);
    }

    public async Task<bool> DeleteBlobAsync(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            throw new ArgumentNullException(nameof(fileName));
        }

        var client = _blobContainerClient.GetBlobClient(fileName);

        var result = await client.DeleteIfExistsAsync();

        return result.Value;
    }
}