using System;
using System.Collections.Generic;
using System.IO;

namespace Motomatic.Source.Storage
{
    class ScriptManager
    {
        static ScriptManager _Manager;

        List<Script> _Scripts = new List<Script>();

        public static ScriptManager Instance()
        {
            if (_Manager == null) _Manager = new ScriptManager();

            return _Manager;
        }

        private ScriptManager()
        {
            Initialize();
        }

        public void Insert(Script script)
        {
            _Scripts.Add(script);
        }

        public void Remove(string name)
        {
            _Scripts.Remove(_Scripts.Find(s => s.Name.ToLower().Equals(name.ToLower())));
        }

        public Script GetScript(string name)
        {
            return _Scripts.Find(s => s.Name.ToLower().Equals(name.ToLower()));
        }

        public void Load()
        {
            var scripts = Directory.GetFiles(GetBaseDirectory(), "*.ahk");
            foreach (var script in scripts)
                _Scripts.Add(Script.Load(script));
        }

        public void Save()
        {
            foreach (var script in _Scripts)
                File.WriteAllText(string.Format("{0}{1}.ahk", GetBaseDirectory(), script.Name), script.Code);
        }

        private void Initialize()
        {
            if (!Directory.Exists(GetBaseDirectory()))
                Directory.CreateDirectory(GetBaseDirectory());

            Load();
        }

        public string GetBaseDirectory()
        {
            return string.Format("{0}\\Data\\Scripts\\", Environment.CurrentDirectory);
        }
    }
}
