using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models
{
    public class HaffmanArchiver : IArchiverBase
    {
        public byte[] CompressData(byte[] byteArray)
        {

        }

        public byte[] DecompressData(byte[] byteArray)
        {
            throw new NotImplementedException();
        }
    }
}
