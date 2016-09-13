using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.Models.Editor;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Views
{
    class MainView
    {
        #region <- Events & Delegates ->
        public delegate void MapItemHandler(Map map);
        public event MapItemHandler OnMapsChanged;
        #endregion

        Dictionary<Map, MapConfig> _mapConfigs = new Dictionary<Map, MapConfig>();
        List<IResource> _resources = new List<IResource>();

        public MainView()
        {
            _resources = ResourceUtils.LoadResources();

            InitializeView();
        }

        private void InitializeView()
        {
            foreach (IResource resource in _resources)
            {
                if (resource is Map)
                    OnMapsChanged?.Invoke(resource as Map);
            }

        }

        #region <- Map Controller ->
        internal void CreateMap(int id, string name, int width, int height)
        {
            var map = new Map()
            {
                ID = id,
                Name = name,
                Width = width,
                Height = height
            };

            _resources.Add(map);
            _mapConfigs.Add(map, new MapConfig());

            OnMapsChanged?.Invoke(_resources[_resources.Count - 1] as Map);
        }

        internal bool LoadMap(string fileName)
        {
            if (File.Exists(fileName))
            {
                var map = Map.ParseFile(fileName);

                if (!HasResource(map))
                {
                    _resources.Add(map);
                    _mapConfigs.Add(map, new MapConfig());

                    OnMapsChanged?.Invoke(_resources[_resources.Count - 1] as Map);

                    return true;
                }
            }

            return false;
        }

        internal bool LoadMap(int id)
        {
            var maps = GetResources<Map>();
            foreach (var map in maps)
                if (map.ID == id)
                {
                    OnMapsChanged?.Invoke(map);

                    return true;
                }

            return false;
        } 

        internal void RemoveMap(Map map)
        {
            _resources.Remove(map);

            if (_mapConfigs.ContainsKey(map))
                _mapConfigs.Remove(map);
        }

        internal void SaveMap(Map map, string fileName)
        {
            map.SaveFile(fileName);
        }

        internal MapConfig GetConfig(Map map)
        {
            if (_mapConfigs.ContainsKey(map))
                return _mapConfigs[map];

            return null;
        }
        #endregion

        internal int GetResourceID<IResource>()
        {
            return _resources.OfType<IResource>().Count();
        }

        internal List<IResource> GetResources<IResource>()
        {
            return _resources.OfType<IResource>().ToList();
        }

        private bool HasResource<IResource>(IResource resource)
        {
            foreach (var item in _resources)
                if (item.IsEqual(resource))
                    return true;

            return false;
        }

        internal void OverwriteChanges()
        {
            _resources.ForEach(r =>
            {
                r.Copy();
            });
        }

        internal bool HasChanges()
        {
            foreach (IResource resource in _resources)
                if (resource.HasChanges())
                    return true;

            return false;
        }
    }
}
