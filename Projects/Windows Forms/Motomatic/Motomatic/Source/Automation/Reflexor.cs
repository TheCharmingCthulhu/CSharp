using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Motomatic.Source.Automation
{
    class Reflexor
    {
        const string PARSE_CLASS = "([A-z0-9]{1,})->";
        const string PARSE_METHOD = "([A-z0-9]{1,}):";
        const string PARSE_PARAMETERS = "([A-z0-9.]{1,})[,;]|(\"[A - z0 - 9]{1,}\")[,;]";

        internal static InstructionSet Parse(Assembly assembly, string script)
        {
            InstructionBuilder builder = InstructionBuilder.Plan(assembly);

            string[] lines = script.Replace("\r", "^").Replace("\n", "^").Split('^');

            foreach (var line in lines)
            {
                var className = Regex.Match(line, PARSE_CLASS).Groups[1].Value;
                var classMethod = Regex.Match(line, PARSE_METHOD).Groups[1].Value;
                var parameters = Regex.Matches(line, PARSE_PARAMETERS);

                builder.Parse(className, classMethod);
            }

            return builder.Finalize();
        }
    }
}
