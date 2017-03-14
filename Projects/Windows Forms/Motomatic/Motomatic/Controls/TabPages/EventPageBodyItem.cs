using System;
using System.Drawing;

namespace Motomatic.Controls.TabPages
{
    class EventPageBodyItem
    {
        public Image Icon { get; set; }
        public Action Callback { get; set; }

        public EventPageBodyItem(Image icon = null, Action callback = null)
        {
            Icon = icon;
            Callback = callback;
        }
    }
}
