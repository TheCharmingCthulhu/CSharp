using System;
using System.Collections.Generic;

namespace Motomatic.Source.Automating
{
    public class EventChain
    {
        string _Name;

        public string Name { get { return _Name; } }

        public List<Event> Events { get; private set; } = new List<Event>();

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
            Events.Add(ev);

            return this;
        }

        public void RemoveChain(Event ev)
        {
            Events.Remove(ev);
        }

        public void RemoveChain(int index)
        {
            Events.RemoveAt(index);
        }

        public void Execute()
        {
            if (Events.Count > 0)
                Events.ForEach(e => e.Run());
        }
    }
}
