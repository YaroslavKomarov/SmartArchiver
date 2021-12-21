using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class FileSmart
    {
        public FileSmart(FileHeader header, byte[] data)
        {
            this.header = header;
            compressedData = data;
        }

        public FileSmart(byte[] fileSmartInBytes)
        {
            var headerBytes = fileSmartInBytes.Take(HeaderLength);

        }

        public void WriteSmartFile(string path)
        {
            // надо как-то записать файл с особым расшиернием 
        }

        private FileHeader header;
        private byte[] compressedData;
    }
}
