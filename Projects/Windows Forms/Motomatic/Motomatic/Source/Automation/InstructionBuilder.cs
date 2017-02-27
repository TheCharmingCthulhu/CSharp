using System;
using System.Linq;
using System.Reflection;

namespace Motomatic.Source.Automation
{
    class InstructionBuilder
    {
        InstructionSet _Set = new InstructionSet();

        public Assembly Assembly { get; private set; }

        private InstructionBuilder()
        {

        }

        public static InstructionBuilder Plan(Assembly assembly = null)
        {
            return new InstructionBuilder()
            {
                Assembly = assembly != null ? assembly : Assembly.GetExecutingAssembly()
            };
        }

        public InstructionSet Finalize()
        {
            return _Set;
        }

        public InstructionBuilder Parse(string classname, string method)
        {
            if (string.IsNullOrEmpty(classname) || string.IsNullOrEmpty(method)) return this;

            _Set.InsertExpression(Instruction.New(Assembly
                .GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(classname.ToLower()))
                .GetMethods().FirstOrDefault(m => m.Name.ToLower().Equals(method.ToLower())).CreateDelegate(typeof(Action))));

            return this;
        }

        public InstructionBuilder Parse<A, B>(string classname, string method, A value1, B value2)
        {
            if (string.IsNullOrEmpty(classname) || string.IsNullOrEmpty(method)) return this;

            _Set.InsertExpression(Instruction.New(Assembly
                .GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(classname.ToLower()))
                .GetMethods().FirstOrDefault(m => m.Name.ToLower().Equals(method.ToLower())).CreateDelegate(typeof(Action<A,B>)), value1, value2));

            return this;
        }

        public InstructionBuilder Parse<A, B, C>(string classname, string method, A value1, B value2, C value3)
        {
            if (string.IsNullOrEmpty(classname) || string.IsNullOrEmpty(method)) return this;

            _Set.InsertExpression(Instruction.New(Assembly
                .GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(classname.ToLower()))
                .GetMethods().FirstOrDefault(m => m.Name.ToLower().Equals(method.ToLower())).CreateDelegate(typeof(Action<A, B, C>)), value1, value2, value3));

            return this;
        }
    }
}
