using System;
using System.Windows.Input;

namespace TheMVVM.Source.Framework
{
    class DelegateCommand : ICommand
    {
        Action _action;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return _action != null;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }
}
