using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class FileHeader
    {

        public int HeaderLength
        {
            get => typeof(FileHeader)
                .GetFields(System.Reflection.BindingFlags.NonPublic)
                .Where(f => f.FieldType == typeof(HeaderField))
                .Select(f => ((HeaderField)f.GetValue(this)).FieldLength)
                .Sum();
        }

        public FileHeader(string initFormatName)
        {
            this.initFormatName = new HeaderField(initFormatName);
        }

        public static FileHeader TryCreateFileHeaderFromByteArray(byte[] headerBytes)
        {

        }

        private HeaderField initFormatName;

    }
}
