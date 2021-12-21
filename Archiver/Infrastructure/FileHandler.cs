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
        public static byte[] TryReadAllBytes(string path)
        {
            try
            {
                return ReadAllBytes(path);
            }
            catch
            {
                throw; // нужно протолкнуть ошибку на слой UI
            }
        }

        public static void TryWriteAllBytes(byte[] bytes, string path)
        {
            try
            {
                WriteAllBytes(bytes, path);
            }
            catch
            {
                throw; // нужно протолкнуть ошибку на слой UI
            }
        }

        public static string GetFileFormatFromPath(string path)
        {
            return Path.GetExtension(path);
        }

        private static byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        private static void WriteAllBytes(byte[] bytes, string path)
        {
            File.WriteAllBytes(path, bytes);
        }
    }
}
