using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Motomatic.Source.Automation
{
    class Worker
    {
        private Task _Keeper;
        private CancellationTokenSource _KeeperToken = new CancellationTokenSource();
        public Stack<InstructionSet> Pool { get; set; } = new Stack<InstructionSet>();

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
                if (Pool.Count > 0)
                {
                    InstructionSet instruct = Pool.Pop();
                }

                if (_KeeperToken.IsCancellationRequested) return;
            }
        }

        public void Run(InstructionSet instructions)
        {
            if (_Keeper == null) Begin();

        }
    }
}
