using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            //использвать флаговые биты 
            //Можно попробовать смотреть по сигнатуре, посмотреть на zip, rar
            var headersBytes = fileSmartInBytes.Take(headerSize).ToArray();
            header = new FileHeader(headersBytes);
            accecoryData = GetByteArray(fileSmartInBytes, headerSize, header.AccecoryDataSize); //при передаче IEnumerable в конструктор убрать Skip()
            compressedData = GetByteArray(fileSmartInBytes, headerSize + accecoryData.Length, header.CompressedDataSize);//при передаче IEnumerable в конструктор убрать Skip()
        }

        public void WriteSmartFile(string path)
        {
            // надо как-то записать файл с особым расшиернием 
        }

        private byte[] GetByteArray(byte[] bytes, int skipCount, int takeCount)
        {
            //при передаче IEnumerable в конструктор убрать Skip()
            return bytes.Skip(skipCount).Take(takeCount).ToArray();
        }

        private FileHeader header;
        private byte[] accecoryData;
        private byte[] compressedData;
        private static readonly int headerSize = 7;
    }
}
