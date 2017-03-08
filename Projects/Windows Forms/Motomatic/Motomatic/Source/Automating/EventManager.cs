using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Motomatic.Source.Automating
{
    class EventManager
    {
        const int EVENT_SLEEP = 100;

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

        public bool Create(EventChain ev)
        {
            if (!Directory.Exists(GetEventPath() + ev.Name))
            {
                Directory.CreateDirectory(GetEventPath() + ev.Name);

                _EventChains.Add(ev);

                return true;
            }

            return false;
        }

        public bool Delete(EventChain ev)
        {
            if (Directory.Exists(GetEventPath() + ev.Name))
            {
                Directory.Delete(GetEventPath() + ev.Name, true);

                _EventChains.Remove(ev);

                return true;
            }

            return false;
        }

        public string GetEventPath()
        {
            return string.Format("{0}\\Data\\Events\\", Environment.CurrentDirectory);
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
