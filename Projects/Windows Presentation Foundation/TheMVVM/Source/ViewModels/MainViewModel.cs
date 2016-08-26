using System.Collections.ObjectModel;
using System.Windows.Input;
using TheMVVM.Source.Framework;
using TheMVVM.Source.Models;
using TheMVVM.Source.ViewModels;

namespace TheMVVM.Source.Views
{
    public class MainViewModel : NotifyObject
    {
        ObservableCollection<Person> _persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons { get { return _persons; } set { _persons = value; } }

        public Person Person { get; set; }
        public PersonViewModel PersonViewModel { get; set; } = new PersonViewModel();

        public string Message { get { return GetProperty<string>("Message", "None"); } set { SetProperty<string>("Message", value); } }

        #region <- Commands ->
        public ICommand AddPersonCommand { get; set; }
        public ICommand EditPersonCommand { get; set; }
        public ICommand RemovePersonCommand { get; set; }

        public ICommand SavePersonListCommand { get; set; }
        public ICommand LoadPersonListCommand { get; set; }
        #endregion

        public MainViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddPersonCommand = new DelegateCommand(AddPerson);
            EditPersonCommand = new DelegateCommand(EditPerson);
            RemovePersonCommand = new DelegateCommand(RemovePerson);

            SavePersonListCommand = new DelegateCommand(SavePersonList);
            LoadPersonListCommand = new DelegateCommand(LoadPersonList);
        }

        #region <- Person ->
        public void AddPerson()
        {
            if (PersonViewModel.Person.HasMissingDetails()) return;

            var person = new Person()
            {
                ID = _persons.Count + 1,
                Name = PersonViewModel.Person.Name,
                Surname = PersonViewModel.Person.Surname,
            };

            person.GenerateKeycode();

            PersonViewModel.ClearPersonCommand.Execute(null);

            _persons.Add(person);
        }

        public void EditPerson()
        {

        }

        public void RemovePerson()
        {
            if (Person == null) return;

            Person.Delete();

            _persons.Remove(Person);
        } 
        #endregion

        #region <- Storage ->
        private void LoadPersonList()
        {
            _persons.Clear();

            var items = Person.LoadAll();

            foreach (var item in items) 
                _persons.Add(item);

            Message = "Data Loaded...";
        }

        private void SavePersonList()
        {
            foreach (var person in _persons)
                Person.Save(person);

            _persons.Clear();

            Message = "Data Saved...";
        }
        #endregion
    }
}
