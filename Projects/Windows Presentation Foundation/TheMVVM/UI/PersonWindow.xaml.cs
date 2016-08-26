using System.Windows;
using TheMVVM.Source.ViewModels;

namespace TheMVVM.UI
{
    public partial class PersonWindow : Window
    {
        PersonViewModel _viewModel;

        public PersonWindow(PersonViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            DataContext = _viewModel;
        }

        public static void Run(PersonViewModel viewModel)
        {
            new PersonWindow(viewModel).ShowDialog();
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            if (!_viewModel.Person.HasMissingDetails())
                DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
