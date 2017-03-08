using System;
using System.Threading.Tasks;

namespace Motomatic.Source.Automating
{
    public abstract class Event : Automation
    {
        public delegate void EventHandler(AutoHotkey.Interop.AutoHotkeyEngine engine, object result);
        public event EventHandler Handler;

        public TimeSpan Delay { get { return _Delay; } }

        TimeSpan _Delay;

        public void Execute()
        {
            EventLoop();
        }

        public Event Callback(EventHandler handler)
        {
            Handler += handler;

            return this;
        }

        public void SetDelay(TimeSpan delay)
        {
            _Delay = delay;
        }

        private async void EventLoop()
        {
            await Task.Delay(_Delay);

            Handler?.Invoke(Engine, Observe());
        }

        protected abstract object Observe();
    }
}
