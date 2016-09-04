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

        public Tool Tool { get; set; } = new Tool();

        List<Map> _maps = new List<Map>();

        internal int GetNewID()
        {
            return _maps.Count;
        }

        #region <- Map Control ->
        internal void CreateMap(int id, string name, int width, int height)
        {
            _maps.Add(new Map()
            {
                ID = id,
                Name = name,
                Width = width,
                Height = height
            });

            if (OnMapsChanged != null)
                OnMapsChanged(_maps[_maps.Count - 1]);
        }

        internal bool LoadMap(string fileName)
        {
            if (File.Exists(fileName))
            {
                _maps.Add(Map.ParseFile(fileName));

                if (OnMapsChanged != null)
                    OnMapsChanged(_maps[_maps.Count - 1]);

                return true;
            }

            return false;
        } 
        #endregion
    }
}
