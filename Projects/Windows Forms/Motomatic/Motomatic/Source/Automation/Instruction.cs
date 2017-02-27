using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motomatic.Source.Automation
{
    class Instruction
    {
        public Delegate Expression { get; set; }
        public object[] Parameters { get; set; }

        public static Instruction New(Delegate method, params object[] parameters)
        {
            return new Instruction()
            {
                Expression = method,
                Parameters = parameters
            };
        }
    }
}
