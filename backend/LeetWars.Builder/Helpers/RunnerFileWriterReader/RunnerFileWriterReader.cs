namespace LeetWars.Builder.Helpers.RunnerFileWriterReader;

public class RunnerFileWriterReaderClass
{
    public async Task WriteContentAsync(string path, string content)
    {
        using (StreamWriter writer = File.CreateText(path))
        {
            await writer.WriteAsync(content);
        }
    }

    public async Task<string> ReadContentAsync(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            return await reader.ReadToEndAsync();
        }
    }
}
