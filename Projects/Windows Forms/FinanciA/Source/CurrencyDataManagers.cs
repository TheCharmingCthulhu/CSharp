using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinanciA.Source
{
    public class CurrencyDataManager<T> where T : CurrencyDataItem
    {
        public List<T> Items { get; set; }

        public CurrencyDataManager(bool autoload = true)
        {
            if (autoload) Load();

            if (Items == null) Items = new List<T>();
        }

        public void Save()
        {
            var file = GetResourceFile();
            var data = JsonConvert.SerializeObject(Items, Formatting.Indented);

            File.WriteAllText(file, data);
        }

        public void Load()
        {
            var file = GetResourceFile();
            var data = File.ReadAllText(file);

            if (!string.IsNullOrEmpty(data))
                Items = JsonConvert.DeserializeObject<List<T>>(data);
        }

        public string GetResourceFile()
        {
            var path = StorageManager.GetStoragePath(1);
            string file = string.Format("{0}{1}{2}", path, GetType().Name, ".json");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (!File.Exists(file))
                File.Create(file).Close();

            return file;
        }

        public decimal GetSum()
        {
            return Items.Sum(item => item.Price);
        }
    }

    public class FixcostManager : CurrencyDataManager<Fixcost>
    {

    }

    public class SalaryManager : CurrencyDataManager<Salary>
    {

    }
}
