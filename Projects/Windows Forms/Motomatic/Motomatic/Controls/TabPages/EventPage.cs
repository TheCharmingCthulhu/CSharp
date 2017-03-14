using System.Windows.Forms;

namespace Motomatic.Controls.TabPages
{
    class EventPage : TabPage
    {
        public EventPageBody Body { get; set; } = new EventPageBody();

        public EventPage()
        {
            Controls.Add(Body);
        }
    }
}
