using LeetWars.Builder.Interfaces;
using SharpCompress.Archives.Tar;
using SharpCompress.Common;
using SharpCompress.Writers;
using SharpCompress.Writers.Tar;
using System.Text;

namespace LeetWars.Builder.Services
{
    public class TarManagementService : ITarManagementService
    {
        public byte[] SingleFileToTarBytes(string input, string newFileNameWithExtension)
        {
            byte[] tarBytes;

            using MemoryStream ms = new();

            using TarWriter writer = new(ms, new TarWriterOptions(CompressionType.None, false));

            using MemoryStream inputMs = new(Encoding.UTF8.GetBytes(input));

            writer.Write(newFileNameWithExtension, inputMs);

            tarBytes = ms.ToArray();

            return tarBytes;
        }

        public async Task<string> FromTarSingleFileToStringAsync(Stream tarData)
        {
            using var memoryStream = new MemoryStream();

            await tarData.CopyToAsync(memoryStream);

            memoryStream.Seek(0, SeekOrigin.Begin);

            using var archive = TarArchive.Open(memoryStream);

            var entry = archive.Entries.FirstOrDefault();

            if (entry != null && !entry.IsDirectory)
            {
                using var entryStream = entry.OpenEntryStream();

                using var sreader = new StreamReader(entryStream);

                string fileContent = sreader.ReadToEnd();

                return fileContent;
            }

            throw new ArgumentException("Invalid input: an invalid data or a directory was given");
        }
    }
}
