using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain;
using System.Reflection;
using Ninject;
using Archiver.Domain.Models.File;
using Archiver.Infrastructure;

namespace Archiver.Application
{
    public class ApplicationLayer
    {
        private readonly IEnumerable<IArchiverBase> archivingAlgorithms;
        public ApplicationLayer()
        {
            var type = typeof(IArchiverBase);
            archivingAlgorithms = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsClass)
                .Select(t => (IArchiverBase)Activator.CreateInstance(t));
        }

        public void Compress(AlgorithmName algName, string pathFrom, string pathTo)
        {
            //Прочитываем все байты FileHandler'ом
            //Передаем эти байты методы CompressData()
            //Создаем объект класса FileSmart и вызываем у него
            try
            {
                var byteArray = FileHandler.TryReadAllBytes(pathFrom);
                var rightImplementation = FindRightImplementation(algName);
                var compressedData = rightImplementation.CompressData(byteArray);
                var header = new FileHeader(FileHandler.GetFileFormatFromPath(pathFrom));
                new FileSmart(header, compressedData).WriteSmartFile(pathTo);
            }
            catch
            {
                // текст ошибки будем пробрасывать в окно формы
            }
        }

        public void Decompress(AlgorithmName algName, string pathFrom, string pathTo)
        {
            try
            {
                var byteArray = FileHandler.TryReadAllBytes(pathFrom);
                var fileSmart = new FileSmart(byteArray);
                var rightImplementation = FindRightImplementation(algName);
                FileHandler.TryWriteAllBytes(rightImplementation.DecompressData(fileSmart), pathTo);
            }
            catch
            {
                // текст ошибки будем пробрасывать в окно формы
            }
        }

        private IArchiverBase FindRightImplementation(AlgorithmName algName)
        {
            return archivingAlgorithms
                .FirstOrDefault(r => r.GetType().Name == algName.ToString());
        }
    }
}
