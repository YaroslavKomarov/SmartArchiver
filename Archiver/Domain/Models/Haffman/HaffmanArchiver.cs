using System;
using System.Collections.Generic;
using Archiver.Domain.Interfaces;

namespace Archiver.Domain.Models
{
    public class HaffmanArchiver : IArchiverBase
    {
        public string AlgorithmExtension => ".haf";

        public byte[] DecompressData(byte[] compressedData, Dictionary<string, byte[]> dictionary)
        {
            throw new NotImplementedException();
        }

        Tuple<byte[], Dictionary<string, byte[]>> IArchiverBase.CompressData(byte[] byteArray)
        {
            throw new NotImplementedException();
        }
    }
}
