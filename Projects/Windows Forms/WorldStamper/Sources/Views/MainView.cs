using System;
using System.Collections.Generic;
using System.IO;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.Models.Editor;

namespace WorldStamper.Sources.Views
{
    class MainView
    {
        #region <- Events & Delegates ->
        public delegate void MapItemHandler(Map map);
        public event MapItemHandler OnMapsChanged;
        #endregion

        Dictionary<Map, MapConfig> _mapConfigs = new Dictionary<Map, MapConfig>();
        List<Map> _maps = new List<Map>();

        internal int GetNewID()
        {
            return _maps.Count;
        }

        internal MapConfig GetConfig(Map map)
        {
            if (_mapConfigs.ContainsKey(map))
                return _mapConfigs[map];

            return null;
        }

        #region <- Map Control ->
        internal void CreateMap(int id, string name, int width, int height)
        {
            var map = new Map()
            {
                ID = id,
                Name = name,
                Width = width,
                Height = height
            };

            _maps.Add(map);
            _mapConfigs.Add(map, new MapConfig());

            if (OnMapsChanged != null)
                OnMapsChanged(_maps[_maps.Count - 1]);
        }

        internal bool LoadMap(string fileName)
        {
            if (File.Exists(fileName))
            {
                var map = Map.ParseFile(fileName);
                _maps.Add(map);
                _mapConfigs.Add(map, new MapConfig());

                if (OnMapsChanged != null)
                    OnMapsChanged(_maps[_maps.Count - 1]);

                return true;
            }

            return false;
        }

        internal void RemoveMap(Map map)
        {
            _maps.Remove(map);

            if (_mapConfigs.ContainsKey(map))
                _mapConfigs.Remove(map);
        }

        internal void SaveMap(Map map, string fileName)
        {
            map.SaveFile(fileName);
        }
        #endregion
    }
}
