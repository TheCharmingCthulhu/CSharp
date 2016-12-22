using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

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

        public void AppendItem(T item)
        {
            Items.Add(item);

            Save();
        }

        public void RemoveItem(T item)
        {
            Items.Remove(item);

            Save();
        }

        public bool ReplaceItem(T item, T newItem)
        {
            var index = Items.IndexOf(item);
            if (index > -1)
            {
                Items.RemoveAt(index);
                Items.Insert(index, newItem);

                Save();

                return true;
            }

            return false;
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
