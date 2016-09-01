using System;
using System.Collections.Generic;
using System.IO;
using WorldStamper.Sources.Models;

namespace WorldStamper.Sources.Views
{
    class MainView
    {
        #region <- Events & Delegates ->
        public delegate void MapItemHandler(Map map);
        public event MapItemHandler OnMapsChanged; 
        #endregion

        public enum MapToolMode
        {
            Cursor,
            Paint,
            Entity
        }

        List<Map> _maps = new List<Map>();

        public MapToolMode ToolMode { get; set; } = MainView.MapToolMode.Cursor;

        public MainView()
        {
            
        }

        private void HandleOnMapsChanged()
        {
            if (OnMapsChanged != null)
                foreach (var map in _maps)
                    OnMapsChanged(map);
        }

        internal int GetNewID()
        {
            return _maps.Count;
        }

        internal void AddMap(int id, string name, int width, int height)
        {
            _maps.Add(new Map()
            {
                ID = id,
                Name = name,
                Width = width,
                Height = height
            });

            HandleOnMapsChanged();
        }

        internal bool LoadMap(string fileName)
        {
            if (File.Exists(fileName))
            {
                _maps.Add(Map.ParseFile(fileName));

                HandleOnMapsChanged();

                return true;
            }

            return false;
        }
    }
}
