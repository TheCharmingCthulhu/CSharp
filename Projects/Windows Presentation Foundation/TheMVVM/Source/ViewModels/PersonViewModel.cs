using System;
using System.Windows.Input;
using TheMVVM.Source.Framework;
using TheMVVM.Source.Models;

namespace TheMVVM.Source.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; } = new Person();

        public ICommand ClearPersonCommand { get; set; }

        public PersonViewModel()
        {
            ClearPersonCommand = new DelegateCommand(ClearPerson);
        }

        private void ClearPerson()
        {
            Person = new Person();
        }
    }
}
