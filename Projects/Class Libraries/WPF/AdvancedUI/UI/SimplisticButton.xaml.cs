using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AdvancedUI.UI
{
    public partial class SimplisticButton : UserControl
    {
        #region <- Dependency Properties ->
        public Brush Border
        {
            get { return (Brush)GetValue(ColorDependency); }
            set { SetValue(ColorDependency, value); }
        }

        public static readonly DependencyProperty ColorDependency = 
            DependencyProperty.Register("Border", typeof(Brush), typeof(SimplisticButton));

        //<----->

        public Brush Color
        {
            get { return (Brush)GetValue(BackColorProperty); }
            set { SetValue(BackColorProperty, value); }
        }

        public static readonly DependencyProperty BackColorProperty = 
            DependencyProperty.Register("Color", typeof(Brush), typeof(SimplisticButton));

        //<----->

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Caption.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(SimplisticButton), new PropertyMetadata(""));


        #endregion

        public SimplisticButton()
        {
            InitializeComponent();
        }
    }
}
