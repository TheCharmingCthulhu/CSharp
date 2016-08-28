using System;
using System.Collections.Generic;
using System.IO;
using WorldStamper.Sources.Models;

namespace WorldStamper.Sources.Views
{
    class MainView
    {
        public delegate void MapItemHandler(Map map);
        public event MapItemHandler OnMapsChanged;

        List<Map> Maps { get; set; } = new List<Map>();

        public MainView()
        {

        }

        public int GetNewID()
        {
            return Maps.Count;
        }

        internal void AddMap(int id, string name, int width, int height)
        {
            Maps.Add(new Map()
            {
                ID = id,
                Name = name,
                Width = width,
                Height = height
            });

            HandleOnMapsChanged();
        }

        private void HandleOnMapsChanged()
        {
            if (OnMapsChanged != null)
                foreach (var map in Maps)
                    OnMapsChanged(map);
        }

        internal bool LoadMap(string fileName)
        {
            if (File.Exists(fileName))
            {
                Maps.Add(Map.ParseFile(fileName));

                HandleOnMapsChanged();

                return true;
            }

            return false;
        }
    }
}
