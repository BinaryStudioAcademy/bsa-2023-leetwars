namespace LeetWars.Builder.Interfaces
{
    public interface ITarManagementService
    {
        byte[] SingleFileToTarBytes(string input, string newFileNameWithExtension);

        Task<string> FromTarSingleFileToStringAsync(Stream tarData);
    }
}
