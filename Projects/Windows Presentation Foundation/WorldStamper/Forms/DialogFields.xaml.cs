using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WorldStamper.Forms
{
    public partial class DialogFields : Window
    {
        public class FieldView
        {
            public static List<BitmapImage> Icons = new List<BitmapImage>();

            public enum FieldType
            {
                STRING,
                INTEGER,
                BOOLEAN
            }

            public FieldView()
            {
                Icons.Add(new BitmapImage(new Uri(Environment.CurrentDirectory + "\\Resources\\Icons\\bullet_red.png")));
                Icons.Add(new BitmapImage(new Uri(Environment.CurrentDirectory + "\\Resources\\Icons\\bullet_blue.png")));
                Icons.Add(new BitmapImage(new Uri(Environment.CurrentDirectory + "\\Resources\\Icons\\bullet_green.png")));
            }

            string _Key = "";
            object _Value = null;
            FieldType _Type;

            public string Key { get { return _Key; } set { _Key = value + ":"; } }

            public object Value {
                get {
                    return _Value;
                }
                set
                {
                    try
                    {
                        if (Type == FieldType.INTEGER)
                            _Value = int.Parse((string)value);
                        else if (Type == FieldType.BOOLEAN)
                            _Value = bool.Parse((string)value);
                        else
                            _Value = value;
                    }
                    catch
                    {
                        _Value = null;

                        if (Type == FieldType.BOOLEAN)
                            _Value = false;
                    }
                }
            }

            public FieldType Type
            {
                get
                {
                    return _Type;
                }
                set
                {
                    if (value == FieldType.STRING)
                        Image = Icons[0];
                    else if (value == FieldType.INTEGER)
                        Image = Icons[1];
                    else if (value == FieldType.BOOLEAN)
                        Image = Icons[2];

                    _Type = value;
                }
            }

            public BitmapImage Image { get; set; }
        }

        public ObservableCollection<FieldView> Fields { get; set; } = new ObservableCollection<FieldView>();

        public DialogFields()
        {
            InitializeComponent();
            InitializeView();
        }

        public static FieldView[] Run(Window owner, params FieldView[] fields)
        {
            var f = new DialogFields();
            f.Owner = owner;

            foreach (var field in fields)
                f.Fields.Add(field);

            var result = f.ShowDialog();

            if(result.HasValue && result.Value)
                return f.Fields.ToArray();

            return null;
        }

        private void InitializeView()
        {
            icFields.ItemsSource = Fields;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            foreach(var values in Fields)
                if (values.Value == null)
                    return;

            DialogResult = true;
        }
    }
}
