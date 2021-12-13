using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain.Models.File;
using System.IO;

namespace Archiver.Infrastructure
{
    public static class FileHandler
    {
        public static byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public static void WriteAllBytes(byte[] bytes, string path)
        {
            File.WriteAllBytes(path, bytes);
        }


    }
}
