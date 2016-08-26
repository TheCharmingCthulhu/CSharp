using System.Windows;
using System.Windows.Controls;

namespace AdvancedUI
{
    public partial class LabelTextBox : UserControl
    {
        #region <- Properties ->
        public string Caption { get { return (string)GetValue(CaptionDependency); } set { SetValue(CaptionDependency, value); } }
        public string Text { get { return (string)GetValue(TextDependency); } set { SetValue(TextDependency, value); } }
        #endregion

        #region <- DepedencyProperty Registration ->
        public static readonly DependencyProperty CaptionDependency = DependencyProperty.Register("Caption", typeof(string), typeof(LabelTextBox));
        public static readonly DependencyProperty TextDependency = DependencyProperty.Register("Text", typeof(string), typeof(LabelTextBox));
        #endregion

        public LabelTextBox()
        {
            InitializeComponent();
        }
    }
}
