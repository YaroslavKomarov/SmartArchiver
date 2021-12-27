using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain.Models.File;

namespace Archiver.Domain.Models
{
    public class HaffmanArchiver : IArchiverBase
    {
        public byte[] CompressData(byte[] byteArray)
        {
            throw new NotImplementedException();
        }

        public byte[] DecompressData(FileSmart fileSmart)
        {
            throw new NotImplementedException();
        }

        public string GetArchiverExtension()
        {
            throw new NotImplementedException();
        }
    }
}
