using AutoHotkey.Interop;
using System;
using System.IO;

namespace Motomatic.Source.Automating
{
    public abstract class Automation
    {
        public enum AutomationLevel
        {
            Expression,
            Raw
        }

        public int ErrorLevel { get { return int.Parse(Engine.GetVar("ErrorLevel")); } }
        protected static AutoHotkeyEngine Engine { get { return AutoHotkeyEngine.Instance; } }

        internal static string Execute(string code, AutomationLevel level = AutomationLevel.Raw, params Variable[] args)
        {
            string result = null;

            foreach (var arg in args)
                Engine.SetVar(arg.Name, arg.Value);

            switch (level)
            {
                case AutomationLevel.Expression:
                    result = Engine.Eval(code);
                    break;
                case AutomationLevel.Raw:
                    Engine.ExecRaw(code);
                    break;
            }

            foreach (var arg in args)
                arg.Value = Engine.GetVar(arg.Name);

            return result;
        }
        internal static string Execute(FileInfo file, AutomationLevel level = AutomationLevel.Raw, params Variable[] args)
        {
            if (File.Exists(file.FullName)) return Execute(File.ReadAllText(file.FullName), level, args);

            return null;
        }
    }
}
