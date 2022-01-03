using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain.Models.File;

namespace Archiver.Domain.Models
{
    class LzwArchiver : IArchiverBase
    {
        public Tuple<byte[], Dictionary<string, byte[]>> CompressData(byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public byte[] DecompressData(FileSmart fileSmart)
        {
            throw new NotImplementedException();
        }
    }
}
