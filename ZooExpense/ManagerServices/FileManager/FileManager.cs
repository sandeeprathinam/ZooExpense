using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ZooExpense.Models;

namespace ZooExpense.ManagerServices.FileManager
{
    public class FileManager:IFileManager
    {
        public Dictionary<string, double> GetPrices(string Filelocation, Dictionary<string, double> Prices)
        {


            var query = (from line in File.ReadAllLines(Filelocation)
                         let values = line.Split('=')
                         select new { Key = values[0], Value = values[1] });

            foreach (var kvp in query)
            {
                Prices[kvp.Key.ToLower()] = Convert.ToDouble(kvp.Value);
            }
            return Prices;
        }

        public List<Animals> GetAnimals(string Filelocation, List<Animals> ListAnimals)
        {
            using FileStream fileStream = new FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read);

            using StreamReader sr = new StreamReader(fileStream, new UTF8Encoding(true));

            var config = new CsvConfiguration(CultureInfo.CurrentCulture) { Delimiter = ";",HasHeaderRecord = false};
            var cr = new CsvReader(sr, config);
            var csvData = cr.GetRecords<Animals>().ToList<Animals>();

            sr.Close();
            return csvData;
        }

        public dynamic FileReader<T>(T item, string Filelocation)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            var reader = new System.Xml.XmlTextReader(Filelocation);
            object obj = deserializer.Deserialize(reader);
            T XmlData = (T)obj;
            reader.Close();
            return XmlData;
        }
    }
}
