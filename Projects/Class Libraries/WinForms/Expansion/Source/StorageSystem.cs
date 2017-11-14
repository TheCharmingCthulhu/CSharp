using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Expansion.Source
{
    public class File
    {
        public string Name { get; set; }
    }

    public class Folder
    {
        public enum DefineType
        {
            Nested,
            Current
        }

        public string Name { get; set; }
        public Folder Parent { get; set; }
        public List<Folder> Folders { get; set; }
        public List<File> Files { get; set; }
        public StorageSystem.FileType Parser { get; set; } = StorageSystem.FileType.XML;

        public Folder(Folder parent, string name)
        {
            Name = name;
            Parent = parent;

            Folders = new List<Folder>();
            Files = new List<File>();
        }

        public Folder AddFolder(string input)
        {
            if (!Directory.Exists(Path.Combine(GetFullPath(), input))) Directory.CreateDirectory(Path.Combine(GetFullPath(), input));

            var folder = new Folder(this, input);
            folder.Files.AddRange(Directory.GetFiles(Path.Combine(GetFullPath(), input)).Select(f => new File() {
                Name = f
            }));

            Folders.Add(folder);

            return folder;
        }

        public Folder AddFolders(DefineType defType, params string[] input)
        {
            Folder folder = this;

            for (int i = 0; i < input.Length; i++)
            {
                if (defType == DefineType.Nested)
                    folder = folder.AddFolder(input[i]);
                else
                    folder = AddFolder(input[i]);
            }

            return folder;
        }

        public bool HasFile(string input)
        {
            return Files.Any(f => Path.GetFileNameWithoutExtension(f.Name).Equals(Path.GetFileNameWithoutExtension(input)));
        }

        public void RemoveFolder(string input)
        {
            if (Folders.RemoveAll(f => f.Name.Equals(input)) > 0)
                Directory.Delete(Path.Combine(GetFullPath(), input), true);

            // TODO: Remove all Folder instances...
        }

        public void AddFile<T>(string input, T data)
        {
            if (!System.IO.File.Exists(Path.Combine(GetFullPath(), input)))
            {
                switch (Parser)
                {
                    case StorageSystem.FileType.XML:
                        var document = new System.Xml.Linq.XDocument();

                        using (var writer = document.CreateWriter())
                            new XmlSerializer(typeof(T)).Serialize(writer, data);

                        document.Save(Path.Combine(GetFullPath(), input + ".xml"));

                        break;

                    case StorageSystem.FileType.JSON:
                        var jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

                        System.IO.File.WriteAllText(Path.Combine(GetFullPath(), input + ".json"), jsonData);

                        break;
                }
            }
        }

        public void ReplaceFile<T>(string input, T data)
        {
            switch (Parser)
            {
                case StorageSystem.FileType.XML:
                    if (string.IsNullOrEmpty(Path.GetExtension(input))) input += ".xml";
                    break;
                case StorageSystem.FileType.JSON:
                    if (string.IsNullOrEmpty(Path.GetExtension(input))) input += ".json";
                    break;
            }

            if (System.IO.File.Exists(Path.Combine(GetFullPath(), input))) System.IO.File.Delete(Path.Combine(GetFullPath(), input));

            AddFile(input, data);
        }

        public void RemoveFile(string input)
        {
            if (System.IO.File.Exists(Path.Combine(GetFullPath(), input)))
                System.IO.File.Delete(Path.Combine(GetFullPath(), input));
        }

        public T GetFile<T>(string input)
        {
            switch (Parser)
            {
                case StorageSystem.FileType.XML:
                    if (string.IsNullOrEmpty(Path.GetExtension(input))) input += ".xml";

                    var document = System.Xml.Linq.XDocument.Load(Path.Combine(GetFullPath(), input));

                    using (var reader = document.CreateReader())
                        return (T)new XmlSerializer(typeof(T)).Deserialize(reader);

                case StorageSystem.FileType.JSON:
                    if (string.IsNullOrEmpty(Path.GetExtension(input))) input += ".json";

                    return (T)Newtonsoft.Json.JsonConvert.DeserializeObject(System.IO.File.ReadAllText(Path.Combine(GetFullPath(), input + ".json")));

                default:
                    return default(T);
            }
        }

        public string GetFullPath()
        {
            List<string> folders = new List<string>() { Name };
            Folder root = Parent;

            while (root != null)
            {
                folders.Add(root.Name);

                root = root.Parent;
            }

            string fullPath = "";

            folders.Reverse();
            folders.ForEach(f => { fullPath += f + "\\"; });

            return fullPath;
        }
    }

    public class StorageSystem
    {
        #region <- Properties ->

        public enum FileType
        {
            XML,
            JSON
        }

        private FileType _parser = StorageSystem.FileType.XML;

        public FileType Parser
        {
            get { return _parser; }
            set
            {
                _parser = value;

                ApplyParser(value, RootFolder);
            }
        }

        public Folder RootFolder { get; set; }
        
        #endregion

        public StorageSystem(string input = "", string root = "")
        {
            RootFolder = new Folder(null, 
                Path.Combine(!string.IsNullOrEmpty(root) ? root : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                             !string.IsNullOrEmpty(input) ? input : Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[0]).Remove(Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[0]).IndexOf('.')))));

            if (!Directory.Exists(RootFolder.GetFullPath())) Directory.CreateDirectory(RootFolder.GetFullPath());
        }

        private void ApplyParser(FileType type, Folder root)
        {
            root.Parser = type;

            foreach (var folder in root.Folders)
                ApplyParser(type, folder);
        }
    }
}
