using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class HeaderField
    {
        public readonly string FieldValue;
        public readonly long FieldSize;

        public HeaderField(string value, long size)
        {
            FieldValue = value;
            FieldSize = size;
        }
    }
}
