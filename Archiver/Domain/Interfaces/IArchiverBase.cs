using Archiver.Domain.Models.File;
using System;
using System.Collections.Generic;

namespace Archiver.Domain
{
    public interface IArchiverBase
    {
        Tuple<byte[], Dictionary<string, byte[]>> CompressData(byte[] bytes);
        byte[] DecompressData(FileSmart fileSmart);
    }
}
