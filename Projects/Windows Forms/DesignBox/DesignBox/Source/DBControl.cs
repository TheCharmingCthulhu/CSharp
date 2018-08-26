using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DesignBox.Source
{
    public class DBControl
    {
        Type _type;

        #region Properties
        public String Name
        {
            get
            {
                return _type.Name;
            }
        }

        public UserControl Control { get; set; }
        #endregion

        public DBControl(Type type)
        {
            _type = type;
        }

        public UserControl Create()
        {
            if (Activator.CreateInstance(_type) is UserControl instance)
            {
                // Initialize and set ..

                Control = instance;
                Control.BorderStyle = BorderStyle.FixedSingle;
            } 

            // Falls kein "UserControl", return null ..
            return Control as UserControl;
        }
    }
}
