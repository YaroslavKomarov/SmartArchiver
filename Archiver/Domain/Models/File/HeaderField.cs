using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class HeaderField
    {
        public string FieldValue { get; private set; }
        public int FieldLength
        {
            get => FieldValue.Length;
        }

        public HeaderField(string value)
        {
            FieldValue = value;
        }
    }
}
