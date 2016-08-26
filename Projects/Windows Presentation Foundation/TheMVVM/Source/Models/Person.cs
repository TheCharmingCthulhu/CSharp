using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TheMVVM.Source.Framework;

namespace TheMVVM.Source.Models
{
    [Serializable]
    public class Person
    {
        const string FILE_PATH = "\\Data";

        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Keycode { get; set; }

        public Person()
        {

        }

        public void GenerateKeycode()
        {
            Keycode = (ID.ToString() + Name + Surname).GetHashCode().ToString("X");
        }

        public bool HasMissingDetails()
        {
            return !(ID > -1 &&
                   Name != null && !Name.Trim().Equals("") &&
                   Surname != null && !Surname.Trim().Equals(""));
        }

        public static void Save(Person item)
        {
            var path = Environment.CurrentDirectory + FILE_PATH;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            var fileName = string.Format("{0}\\{1}.bin", path, item.Keycode);

            if (!File.Exists(fileName))
                using (var stream = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    var formatter = new BinaryFormatter();

                    formatter.Serialize(stream, item);
                }
        }

        public static Person Load(string fileName)
        {
            if (File.Exists(fileName))
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();

                    return (Person)formatter.Deserialize(stream);
                }

            return null;
        }

        public static List<Person> LoadAll()
        {
            var items = new List<Person>();

            var path = Environment.CurrentDirectory + FILE_PATH;

            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);

                foreach (var file in files)
                    items.Add(Load(file));
            }

            return items;
        }

        public void Delete()
        {
            var path = string.Format("{0}{1}\\{2}.bin", Environment.CurrentDirectory, FILE_PATH, Keycode);

            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
