using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain.Models.File;

namespace Archiver.Domain
{
    public interface IArchiverBase
    {
        byte[] CompressData(byte[] byteArray);
        byte[] DecompressData(FileSmart fileSmart);
    }
}
