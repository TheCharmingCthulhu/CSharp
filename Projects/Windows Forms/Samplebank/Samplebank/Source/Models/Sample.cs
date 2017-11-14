using System;
using System.IO;
using System.Security.Cryptography;
using FsqLite.Source;

namespace Samplebank.Source.Models
{
    class Sample
    {
        [Field("TEXT")]
        public string Name { get; set; }
        [Field("INTEGER")]
        public long Size { get; set; }
        [Field("REAL")]
        public TimeSpan Duration { get; set; }
        [Index]
        [Field("TEXT")]
        public string Hash { get; set; }
        [Field("TEXT")]
        public string Source { get; set; }
        [Field("TEXT")]
        public string Path { get; set; }

        public Sample()
        {
        }

        public Sample(string path, string source = "None")
        {
            Name = System.IO.Path.GetFileNameWithoutExtension(path);
            Path = path;
            Source = source;

            if (File.Exists(path))
                using (var stream = File.OpenRead(path))
                {
                    Size = stream.Length;

                    Hash = RetrieveMD5(stream);
                }
        }

        private string RetrieveMD5(FileStream stream)
        {
            using (var md5 = MD5.Create())
                return Hex(md5.ComputeHash(stream));
        }

        private string Hex(byte[] hash)
        {
            string result = "";
            for (int i = 0; i < hash.Length; i++)
                result += hash[i].ToString("X2");

            return result;
        }
    }
}
