using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver.Domain;
using System.Reflection;
using Ninject;
using Archiver.Domain.Models.File;

namespace Archiver.Application
{
    public class ApplicationHandler
    {
        private readonly HashSet<IArchiverBase> archivingAlgorithms;
        public ApplicationHandler()
        {
            //var tmp = Assembly.GetExecutingAssembly();
            //foreach (var type in tmp.GetTypes())
            //{
            //    if (typeof(IArchiverBase).IsAssignableFrom(type))
            //    {
            //        archivingAlgorithms.Add(type.GetConstructor())
            //    }
            //}
            //var container = new StandardKernel();
            //container.Bind<IArchiverBase>().ToMethod(c => c.FromThisAssembly().SelectAllClasses().BindAllBaseClasses())
        }

        public void Compress(AlgorithmName algName, string pathFrom, string PathTo)
        {
            //Прочитываем все байты FileHandler'ом
            //Передаем эти байты методы CompressData()
            //Создаем объект класса FileSmart и вызываем у него метод

        }

        public void Decompress(AlgorithmName algName, string pathFrom, string PathTo)
        {

        }
    }
}
