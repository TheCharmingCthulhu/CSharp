using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Motomatic.Source.Automating
{
    public abstract class Event : Automation
    {
        public delegate void EventHandler(AutoHotkey.Interop.AutoHotkeyEngine engine, object result);

        [Browsable(false)]
        public string Script { get; set; }

        [Browsable(false)]
        public bool Status { get; private set; } = false;

        [Browsable(false)]
        public List<string> Parameters { get; set; } = new List<string>();

        TimeSpan _Delay;

        public void Run()
        {
            EventLoop();
        }

        public void SetDelay(TimeSpan delay)
        {
            _Delay = delay;
        }

        private async void EventLoop()
        {
            await Task.Delay(_Delay);

            Status = Observe();

            if (Status && !string.IsNullOrEmpty(Script))
            {
                for (int i = 0; i < Parameters.Count; i++)
                    Engine.SetVar(string.Format("param{0}", i), Parameters[i]);

                Engine.ExecRaw(Script);
            }
        }

        protected abstract bool Observe();
    }
}
