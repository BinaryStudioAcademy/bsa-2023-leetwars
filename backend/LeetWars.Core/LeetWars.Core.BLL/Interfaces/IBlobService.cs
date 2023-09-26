namespace LeetWars.Core.BLL.Interfaces;

public interface IBlobService
{
    string GetBlob(string fileName);

    Task UploadFileBlobAsync(Stream stream, string contentType, string uniqueName);

    Task<bool> DeleteBlobAsync(string fileName);
}