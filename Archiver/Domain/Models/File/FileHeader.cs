using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class FileHeader
    {
        public readonly int CompressedDataSize;
        public readonly string InitFormatName;
        public readonly int AccecoryDataSize;

        public long HeaderSize
        {
            get => typeof(FileHeader)
                .GetFields(System.Reflection.BindingFlags.NonPublic)
                .Where(f => f.FieldType == typeof(HeaderField))
                .Select(f => ((HeaderField)f.GetValue(this)).FieldSize)
                .Sum();
        }

        public FileHeader(string initFormatName)
        {
            this.InitFormatName = initFormatName;
        }

        public FileHeader(byte[] headerBytes)
        {
            InitFormatName = BitConverter.ToString(headerBytes, 0, AccessoryFileHeader.initFormatSize);
            AccecoryDataSize = BitConverter.ToInt32(headerBytes.Take(AccessoryFileHeader.accecoryDataSizeSize).ToArray(), 0);
            CompressedDataSize = BitConverter.ToInt32(headerBytes.Take(AccessoryFileHeader.compressedDataSizeSize).ToArray(), 0);
        }

        static class AccessoryFileHeader
        {
            //public static Dictionary<string, int> headersFieldsSizeDict = new Dictionary<string, int> 
            //{
            //    {"initFormat", 5},
            //    {"accecoryDataSize", 1024}
            //};

            public static readonly int initFormatSize = 5;
            public static readonly int accecoryDataSizeSize = 2;
            public static readonly int compressedDataSizeSize = 2;
        }
    }
}
