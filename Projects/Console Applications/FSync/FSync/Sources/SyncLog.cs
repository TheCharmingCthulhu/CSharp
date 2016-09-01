using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FSync.Sources
{
    class SyncLog : IDisposable
    {
        Queue<string> _log;

        public enum LogType
        {
            Info,
            Warning,
            Error,
        }

        public SyncLog()
        {
            _log = new Queue<string>();

            var fileStream = new FileStream(Environment.CurrentDirectory + "\\Sync.log",  FileMode.OpenOrCreate, FileAccess.Read);

            using (var stream = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line = "";
                while((line = stream.ReadLine()) != null)
                    _log.Enqueue(line);
            };

            fileStream.Close();
        }

        public void Push(LogType type, string description)
        {
            switch (type)
            {
                case LogType.Info:
                    _log.Enqueue(string.Format("[{0}][INFO]:{1}", DateTime.Now, description));
                    break;

                case LogType.Warning:
                    _log.Enqueue(string.Format("[{0}][WARNING]:{1}", DateTime.Now, description));
                    break;

                case LogType.Error:
                    _log.Enqueue(string.Format("[{0}][ERROR]:{1}", DateTime.Now, description));
                    break;
            }
        }

        public void Dispose()
        {
            using (var stream = new StreamWriter(Environment.CurrentDirectory + "\\Sync.log", false))
                while (_log.Count > 0)
                    stream.WriteLine(_log.Dequeue());
        }
    }
}
