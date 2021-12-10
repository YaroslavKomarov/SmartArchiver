using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Domain.Models.File
{
    public class FileHeader
    {
        public AlgorithmName AlgorithmName { get; private set; }
        public string InitFormatName { get; private set; }

        public FileHeader(AlgorithmName algName, string formatName)
        {
            AlgorithmName = algName;
            InitFormatName = formatName;
        }
    }
}
