using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class FileSmart
    {
        public FileHeader Header { get; private set; }
        public byte[] CompressedData { get; private set; }

        public FileSmart(FileHeader header, byte[] data)
        {
            Header = header;
            CompressedData = data;
        }
    }
}
