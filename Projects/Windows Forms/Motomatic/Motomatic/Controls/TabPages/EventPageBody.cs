using Motomatic.Source.Automating;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using Motomatic.Forms;
using Motomatic.Source.Automating.Operations.System;

namespace Motomatic.Controls.TabPages
{
    public partial class EventPageBody : UserControl
    {
        Dictionary<string, EventPageBodyItem> _Events = new Dictionary<string, EventPageBodyItem>();

        public Event ActiveEvent { get; set; }

        public EventPageBody()
        {
            InitializeComponent();
            InitializeView();

            Dock = DockStyle.Fill;
        }

        private void InitializeView()
        {
            flowLayoutPanelEvents.HorizontalScroll.Visible = true;
            flowLayoutPanelEvents.AutoScroll = true;

            InitializeCustomEvents();
        }

        private void InitializeCustomEvents()
        {
            _Events["ImageSearch"] = new EventPageBodyItem(Properties.Resources.search, () =>
            {
                FormEventEditor.Run(new MotoImage.Search(""));
            });

            _Events["WindowWait"] = new EventPageBodyItem(callback: () => {

            });

            _Events["A"] = new EventPageBodyItem(callback: () => {

            });

            _Events["B"] = new EventPageBodyItem(callback: () => {

            });

            _Events["C"] = new EventPageBodyItem(callback: () => {

            });

            foreach (var ev in _Events)
            {
                var dragPictureBox = new DraggablePictureBox()
                {
                    Name = ev.Key,
                    Callback = ev.Value.Callback,
                    DragDefaultControl = flowLayoutPanelEvents,
                    DragTarget = pictureBoxEventImage,
                    Image = ev.Value.Icon,
                };

                flowLayoutPanelEvents.Controls.Add(dragPictureBox);

                dragPictureBox.Tag = flowLayoutPanelEvents.Controls.GetChildIndex(dragPictureBox);
                dragPictureBox.DraggablePictureBoxDragDrop += DragPictureBox_DraggablePictureBoxDragDrop;
            }

            flowLayoutPanelEvents.Controls.Add(new Panel()
            {
                Width = 10,
                Height = 5
            });
        }

        private void DragPictureBox_DraggablePictureBoxDragDrop(object sender)
        {
            flowLayoutPanelEvents.Controls.SetChildIndex((sender as Control), Convert.ToInt32((sender as Control).Tag));

            var view = (sender as DraggablePictureBox);
            if (view != null && view.IsMouseOverDragTarget())
            {
                pictureBoxEventImage.Image = view.Image;
                labelEventInfo.Text = view.Name;
            }
        }
    }
}
