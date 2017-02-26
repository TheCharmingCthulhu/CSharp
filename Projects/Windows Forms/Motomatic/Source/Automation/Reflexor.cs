using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Motomatic.Source.Automation
{
    class Reflexor
    {
        public const string PARSER = "([A-z0-9]{1,})->([A-z0-9]{1,}):|([A-z0-9]{1,})[,;]";

        internal static long Parse(string script)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            string[] lines = script.Replace("\r", "^").Replace("\n", "^").Split('^');

            foreach (var line in lines)
            {
                var matches = Regex.Matches(line, PARSER);
                var args = new List<object>();

                foreach (Match match in matches)
                    if (!string.IsNullOrEmpty(match.Groups[3].Value)) args.Add(int.Parse(match.Groups[3].Value));

                switch (args.Count)
                {
                    case 2:
                        InstructionBuilder.Plan().Parse(matches[0].Groups[1].Value, matches[0].Groups[2].Value, int.Parse(args[0].ToString()), int.Parse(args[1].ToString())).Finalize().Call("move");
                        break;
                }

                //Execute(Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(matchCol[0].Groups[1].Value)), matchCol[0].Groups[2].Value, null, args.ToArray());
            }

            watch.Stop();

            return watch.ElapsedTicks;
        }
    }
}
