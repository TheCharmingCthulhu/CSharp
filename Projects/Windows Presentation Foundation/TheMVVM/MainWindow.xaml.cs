using System.Windows;
using TheMVVM.Source.Views;
using TheMVVM.UI;

namespace TheMVVM
{
    public partial class MainWindow : Window
    {
        MainViewModel _viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _viewModel;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow.Run(_viewModel.PersonViewModel);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.LoadPersonListCommand?.Execute(null);
        }
    }
}
