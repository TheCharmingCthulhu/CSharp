using System.Windows;
using WorldStamper.Forms;
using WorldStamper.Source.View;

namespace WorldStamper
{
    public partial class MainWindow : Window
    {
        RootView view;

        public MainWindow()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            view = new RootView();

            tcMapEditor.ItemsSource = view.Maps;
        }

        private void MapNew_Click(object sender, RoutedEventArgs e)
        {
            DialogCreateMap();
        }

        private void DialogCreateMap()
        {
            var fields = DialogFields.Run(this, 
                new DialogFields.FieldView()
                {
                    Key = "Name",
                    Type = DialogFields.FieldView.FieldType.STRING
                },
                new DialogFields.FieldView()
                {
                    Key = "Width",
                    Type = DialogFields.FieldView.FieldType.INTEGER,
                    Value = "32"
                },
                new DialogFields.FieldView()
                {
                    Key = "Height",
                    Type = DialogFields.FieldView.FieldType.INTEGER,
                    Value = "32"
                });

            if (fields != null)
                view.Maps.Add(new MapView()
                {
                    Map = new Source.Map()
                    {
                        Name = (string)fields[0].Value,
                        Width = (int)fields[1].Value,
                        Height = (int)fields[2].Value,
                    }
                });
        }
    }
}
