using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models.Editor.Configs;
using WorldStamper.Sources.Models.Maps;
using WorldStamper.Sources.Utilities;

namespace WorldStamper.Sources.Views
{
    class MainView
    {
        #region <- Events & Delegates ->
        public delegate void MapItemHandler(Map map);
        public event MapItemHandler OnMapsChanged;
        #endregion

        Dictionary<IResource, IConfig> _configs = new Dictionary<IResource, IConfig>();
        List<IResource> _resources = new List<IResource>();

        public MainView()
        {
            _resources = ResourceUtils.LoadResources();

            InitializeMaps();
            InitializeView();
        }

        private void InitializeMaps()
        {
            var maps = GetResources<Map>();
            foreach (var map in maps)
                _configs.Add(map, new MapConfig());
        }

        private void InitializeView()
        {
            foreach (IResource resource in _resources)
                if (resource is Map)
                    OnMapsChanged?.Invoke(resource as Map);
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
            _configs.Add(map, new MapConfig());

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
                    _configs.Add(map, new MapConfig());

                    OnMapsChanged?.Invoke(_resources[_resources.Count - 1] as Map);

                    return true;
                }
            }

            return false;
        }

        internal bool LoadMap(int id)
        {
            var map = GetResources<Map>().FirstOrDefault(m => m.ID == id);

            if (map != null)
            {
                OnMapsChanged?.Invoke(map);

                return true;
            }

            return false;
        }

        internal void RemoveMap(Map map)
        {
            _resources.Remove(map);

            if (_configs.ContainsKey(map))
                _configs.Remove(map);
        }

        internal void SaveMap(Map map, string fileName)
        {
            map.SaveFile(fileName);
        }

        internal IConfig GetConfig(IResource resource)
        {
            if (_configs.ContainsKey(resource))
                return _configs[resource];

            return null;
        }
        #endregion

        #region <- Resources ->
        internal int GetResourceID<IResource>()
        {
            return _resources.OfType<IResource>().Count();
        }

        internal List<T> GetResources<T>() where T : IResource
        {
            return _resources.OfType<T>().ToList();
        }

        internal List<T> GetModifiedResources<T>() where T : IResource
        {
            return _resources.OfType<T>().Where(r => r.HasChanges()).ToList();
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
                if (r is Map)
                    (r as Map).CopyToOriginal();
            });
        }

        internal void OverwriteChange(IResource resource)
        {
            if (resource is Map) (resource as Map).CopyToOriginal();
        }

        internal bool HasChanges()
        {
            foreach (IResource resource in _resources)
                if (resource.HasChanges())
                    return true;

            return false;
        }

        internal void SaveResources()
        {
            foreach (IResource resource in _resources)
                resource.SaveFile(resource.GetFilename());

            ResourceUtils.SaveResources(_resources.ToArray());
        } 
        #endregion
    }
}
