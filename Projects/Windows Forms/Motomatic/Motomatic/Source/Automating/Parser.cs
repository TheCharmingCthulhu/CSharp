using System.Collections.Generic;

namespace Motomatic.Source.Automating
{
    class Parser
    {
        List<string> _Code = new List<string>();

        public static Parser New()
        {
            return new Parser();
        }

        public Parser Chain(string line, params object[] args)
        {
            _Code.Add(string.Format(line + "\r\n", args));

            return this;
        }

        public string Finalize()
        {
            string code = "";

            foreach(var line in _Code)
                code += line;

            return code;
        }

        public void Remove(int index)
        {
            _Code.RemoveAt(index);
        }
    }
}
