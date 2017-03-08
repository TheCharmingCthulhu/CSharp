using Motomatic.Source.Automating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Motomatic.Source.Storage
{
    class Script
    {
        const string AHK_EXPRESSION = "([A-z0-9]*)[:]{0,}=(.*)";

        string _Code;

        public string Name { get; set; }
        public string Code { get { return _Code; } }

        public static Script Load(string filename)
        {
            if (File.Exists(filename))
                return new Script(Path.GetFileNameWithoutExtension(filename), File.ReadAllText(filename));

            return null;
        }

        public Script(string name, string code)
        {
            Name = name;
            _Code = code;
        }

        public bool Execute(params Variable[] args)
        {
            if (IsScriptValid(args))
            {
                Automation.Execute(_Code, Automation.AutomationLevel.Raw, args);

                return true;
            }

            return false;
        }

        private bool IsScriptValid(Variable[] args)
        {
            var matches = Regex.Matches(_Code, AHK_EXPRESSION);
            foreach (Match match in matches)
                if (args.Any(v => v.Name.ToLower().Equals(match.Groups[1].Value.ToLower())))
                    throw new Exception(string.Format("EXCEPTION: Script \"{0}\" contains an assignment to variable \"%{1}%\"", Name, match.Groups[1].Value));

            return true;
        }
    }
}
