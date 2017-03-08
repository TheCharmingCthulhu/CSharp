using System;
using System.Collections.Generic;

namespace Motomatic.Source.Automating
{
    class EventChain
    {
        string _Name;
        List<Event> _Events = new List<Event>();

        public string Name { get { return _Name; } }

        public EventChain(string name)
        {
            _Name = name;
        }

        public static EventChain New(string name)
        {
            return new EventChain(name);
        }

        public EventChain Chain(Event ev)
        {
            _Events.Add(ev);

            return this;
        }

        public EventChain Chain<T>(Event.EventHandler handler, params object[] args) where T : Event
        {
            var callback = handler != null ? handler : new Event.EventHandler((engine, obj) => { });

            _Events.Add(((Event)Activator.CreateInstance(typeof(T), args)).Callback(callback));

            return this;
        }

        public void UnChain(Event ev)
        {
            _Events.Remove(ev);
        }

        public void UnChain(int index)
        {
            _Events.RemoveAt(index);
        }

        public void Execute()
        {
            if (_Events.Count > 0)
                _Events.ForEach(e => e.Execute());
        }
    }
}
