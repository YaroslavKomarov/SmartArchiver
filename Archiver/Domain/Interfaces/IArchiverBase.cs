using Archiver.Domain.Models.File;

namespace Archiver.Domain
{
    public interface IArchiverBase
    {
        byte[] CompressData(byte[] byteArray);
        byte[] DecompressData(FileSmart fileSmart);
    }
}
