using System.Collections.Generic;
using System.ComponentModel;

namespace TheMVVM.Source.Framework
{
    public class NotifyObject : INotifyPropertyChanged
    {
        Dictionary<string, object> _properties = new Dictionary<string, object>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(string propertyName, T value)
        {
            if (!_properties.ContainsKey(propertyName)) _properties.Add(propertyName, null);

            _properties[propertyName] = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public T GetProperty<T>(string propertyName, T value = default(T))
        {
            return _properties.ContainsKey(propertyName) ? (T)_properties[propertyName] : value;
        }
    }
}
