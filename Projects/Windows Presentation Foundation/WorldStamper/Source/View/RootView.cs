using System;
using System.Collections.ObjectModel;

namespace WorldStamper.Source.View
{
    public class RootView
    {
        public ObservableCollection<MapView> Maps { get; set; } = new ObservableCollection<MapView>();

        public RootView(bool debug = false)
        {
            if (debug)
                DebugView();
        }

        private void DebugView()
        {
            Maps.Add(new MapView()
            {
                Map = new Map()
                {
                    Name = "map_01",
                    Width = 20,
                    Height = 20
                }
            });
        }
    }
}
