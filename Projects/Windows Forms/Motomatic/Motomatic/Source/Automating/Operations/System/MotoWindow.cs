using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motomatic.Source.Automating.Operations.System
{
    public static class MotoWindow
    {
        public class WindowInfo
        {
            public enum WindowInfoType
            {
                /// <summary>
                /// Window Title: ""
                /// </summary>
                WindowTitle,
                /// <summary>
                /// Window Class: ahk_class 
                /// </summary>
                WindowClass,
                /// <summary>
                /// Unique Window ID/ Handle (HWND): ahk_id
                /// </summary>
                Handle,
                /// <summary>
                /// Process Name / Path: ahk_exe
                /// </summary>
                Process,
                /// <summary>
                /// Process ID: ahk_pid
                /// </summary>
                ProcessID
            }

            string _Value;
            WindowInfoType _Type;

            public static WindowInfo Create(WindowInfoType type, string value)
            {
                return new WindowInfo(type, value);
            }

            public WindowInfo(WindowInfoType type, string value)
            {
                _Type = type;
                _Value = value;
            }

            public string GetWindowInfoType()
            {
                switch (_Type)
                {
                    case WindowInfoType.WindowTitle:
                        return "";
                    case WindowInfoType.WindowClass:
                        return "ahk_class";
                    case WindowInfoType.Handle:
                        return "ahk_id";
                    case WindowInfoType.Process:
                        return "ahk_exe";
                    case WindowInfoType.ProcessID:
                        return "ahk_pid";
                    default:
                        return null;
                }
            }

            public string GetValue()
            {
                return _Value;
            }
        }

        public class Wait : Event
        {
            string _GroupName;
            WindowInfo[] _Windows;

            public Wait(params WindowInfo[] windows) : this("Windows", windows)
            {
                
            }

            public Wait(string groupName, params WindowInfo[] windows)
            {
                _GroupName = groupName;
                _Windows = windows;
            }

            protected override object Observe()
            {
                if (_Windows.Length > 0)
                {
                    if (_Windows.Length == 1)
                    {
                        Engine.ExecRaw(Parser.New()
                            .Chain(string.Format("WinWaitActive, {0} {1},,0.1", _Windows[0].GetWindowInfoType(), _Windows[0].GetValue()))
                            .Finalize());
                    }
                    else
                    {
                        var parser = Parser.New();

                        foreach (var window in _Windows)
                            parser.Chain(string.Format("GroupAdd, {0}, {1} {2}", _GroupName, window.GetWindowInfoType(), window.GetValue()));

                        Engine.ExecRaw(parser
                            .Chain(string.Format("WinWaitActive, ahk_group {0}", _GroupName))
                            .Finalize());
                    }

                    return ErrorLevel == 0;
                }

                return false;
            }
        }
    }
}
