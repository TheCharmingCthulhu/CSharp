using System;
using System.Globalization;
using System.Windows.Data;

namespace WorldStamper
{
    [ValueConversion(typeof(Forms.DialogFields.FieldView.FieldType), typeof(int))]
    public class FieldTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Forms.DialogFields.FieldView.FieldType)value;
        }
    }
}
