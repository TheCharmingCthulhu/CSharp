using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motomatic.Source.Automating
{
    class EventManager
    {
        const int EVENT_SLEEP = 100;
        const string EVENT_FILE = "\\Data\\Events.bin";

        public delegate void EventChainHandler(EventChain ev);
        public event EventChainHandler EventAdd;
        public event EventChainHandler EventRemove;

        public delegate void EventListHandler(List<EventChain> events);
        public event EventListHandler EventListSave;
        public event EventListHandler EventListLoad;

        static EventManager _Manager;

        List<EventChain> _EventChains = new List<EventChain>();

        public static EventManager Instance()
        {
            if (_Manager == null) _Manager = new EventManager();

            return _Manager;
        }

        public EventManager()
        {
            InitializeSettings();

            Task.Run(() => Loop());
        }

        public EventChain Create(string name)
        {
            if (Directory.Exists(GetEventPath() + name))
                Directory.Delete(GetEventPath() + name, true);

            Directory.CreateDirectory(GetEventPath() + name);

            var eventChain = new EventChain(name);

            _EventChains.Add(eventChain);

            EventAdd?.Invoke(eventChain);

            return eventChain;
        }

        public void Delete(string name)
        {
            EventRemove?.Invoke(GetEvent(name));

            if (Directory.Exists(GetEventPath() + name))
                Directory.Delete(GetEventPath() + name, true);

            _EventChains.RemoveAll(ev => ev.Name.ToLower().Equals(name));
        }

        public EventChain GetEvent(string name)
        {
            return _EventChains.Find(ev => ev.Name.ToLower().Equals(name));
        }

        public string GetEventPath()
        {
            return string.Format("{0}\\Data\\Events\\", Environment.CurrentDirectory);
        }

        public void SaveEvents()
        {
            var path = string.Format("{0}\\{1}", Environment.CurrentDirectory, EVENT_FILE);

            File.WriteAllText(Environment.CurrentDirectory + "\\Data\\Events.bin", Convert.ToBase64String(Encoding.Unicode.GetBytes(JsonConvert.SerializeObject(_EventChains))));
        }

        public void LoadEvents()
        {
            var path = string.Format("{0}\\{1}", Environment.CurrentDirectory, EVENT_FILE);

            if (File.Exists(path))
                _EventChains = JsonConvert.DeserializeObject<List<EventChain>>(Encoding.Unicode.GetString(Convert.FromBase64String(File.ReadAllText(path))));

            EventListLoad?.Invoke(_EventChains);
        }

        public void Remove(int index)
        {
            _EventChains.RemoveAt(index);
        }

        private void InitializeSettings()
        {
            if (!Directory.Exists(GetEventPath()))
                Directory.CreateDirectory(GetEventPath());
        }

        private async void Loop()
        {
            while (true)
            {
                _EventChains.ForEach(e => e.Execute());

                await Task.Delay(EVENT_SLEEP);
            }
        }
    }
}
