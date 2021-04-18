using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooExpense.Models;

namespace ZooExpense.ManagerServices.FileManager
{
    public interface IFileManager
    {
        public Dictionary<string, double> GetPrices(string Filelocation, Dictionary<string, double> Prices);

        public List<Animals> GetAnimals(string Filelocation, List<Animals> ListAnimals);
        public dynamic FileReader<T>(T item, string Filelocation);
    }
}
