namespace LeetWars.Core.BLL.Services;

public static class FileNameHelper
{
    public static string CreateUniqueFileName(string fileName)
    {
        var newFileName = Path.GetFileName(fileName);
        var extension = Path.GetExtension(newFileName);
        var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(newFileName);
        var fileGuid = Guid.NewGuid();

        var result = $"{fileNameWithoutExtension}_{fileGuid}{extension}";

        return result;
    }
}