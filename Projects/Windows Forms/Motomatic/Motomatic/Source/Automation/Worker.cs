using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Motomatic.Source.Automation
{
    class Worker
    {
        private Stopwatch _KeeperTime = new Stopwatch(); 
        private Task _Keeper;
        private CancellationTokenSource _KeeperToken = new CancellationTokenSource();
        public Dictionary<EventChain, InstructionSet> Pool { get; private set; } = new Dictionary<EventChain, InstructionSet>();
        public TimeSpan PassDuration { get; private set; }

        public Worker()
        {

        }

        public void Begin()
        {
            End();

            _Keeper = Task.Run(() => { Keeper(); }, _KeeperToken.Token);
        }

        public void End()
        {
            if (_Keeper != null)
                if (_Keeper.Status == TaskStatus.Running)
                {
                    _KeeperToken.Cancel();
                    _Keeper = null;
                }
                else { _Keeper = null; }
        }

        private void Keeper()
        {
            while (true)
            {
                if (_KeeperToken.IsCancellationRequested) return;
            }
        }

        public void Insert(EventChain events, InstructionSet set)
        {
            if (_Keeper == null) Begin();
        }

        public void Remove(int index)
        {

        }
    }
}
