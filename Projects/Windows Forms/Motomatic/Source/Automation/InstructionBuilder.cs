using System;
using System.Linq;
using System.Reflection;

namespace Motomatic.Source.Automation
{
    class InstructionBuilder
    {
        InstructionSet _Set = new InstructionSet();

        public static InstructionBuilder Plan()
        {
            return new InstructionBuilder();
        }

        public InstructionSet Finalize()
        {
            return _Set;
        }

        /// <summary>
        /// Custom function.
        /// </summary>
        public InstructionBuilder Action(Action expr)
        {
            _Set.InsertExpression(Instruction.New(expr));

            return this;
        }

        public InstructionBuilder Action<A, B>(Action<A, B> expr, A value1, B value2)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2));

            return this;
        }

        public InstructionBuilder Action<A, B, C>(Action<A, B, C> expr, A value1, B value2, C value3)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3));

            return this;
        }

        public InstructionBuilder Action<A, B, C, D>(Action<A, B, C, D> expr, A value1, B value2, C value3, D value4)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4));

            return this;
        }

        public InstructionBuilder Action<A, B, C, D, E>(Action<A, B, C, D, E> expr, A value1, B value2, C value3, D value4, E value5)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4, value5));

            return this;
        }

        public InstructionBuilder Action<A, B, C, D, E, F>(Action<A, B, C, D, E, F> expr, A value1, B value2, C value3, D value4, E value5, F value6)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4, value5, value6));

            return this;
        }

        /// <summary>
        /// Custom function with "BOOL" as return value.
        /// </summary>
        public InstructionBuilder Function(Func<bool> expr)
        {
            _Set.InsertExpression(Instruction.New(expr));

            return this;
        }

        public InstructionBuilder Function<A, B>(Func<A, B, bool> expr, A value1, B value2)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2));

            return this;
        }

        public InstructionBuilder Function<A, B, C>(Func<A, B, C, bool> expr, A value1, B value2, C value3)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3));

            return this;
        }

        public InstructionBuilder Function<A, B, C, D>(Func<A, B, C, D, bool> expr, A value1, B value2, C value3, D value4)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4));

            return this;
        }

        public InstructionBuilder Function<A, B, C, D, E>(Func<A, B, C, D, E, bool> expr, A value1, B value2, C value3, D value4, E value5)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4, value5));

            return this;
        }

        public InstructionBuilder Function<A, B, C, D, E, F>(Func<A, B, C, D, E, F, bool> expr, A value1, B value2, C value3, D value4, E value5, F value6)
        {
            _Set.InsertExpression(Instruction.New(expr, value1, value2, value3, value4, value5, value6));

            return this;
        }

        public InstructionBuilder Parse(string classname, string method)
        {
            var classType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(classname.ToLower()));
            _Set.InsertExpression(Instruction.New(Delegate.CreateDelegate(classType, classType.GetMethods().FirstOrDefault(m => m.Name.ToLower().Equals(method)))));

            return this;
        }

        public InstructionBuilder Parse<A, B>(string classname, string method, A value1, B value2)
        {
            _Set.InsertExpression(Instruction.New(Delegate.CreateDelegate(typeof(Action<A, B>), 
                Assembly
                .GetExecutingAssembly()
                .GetTypes().FirstOrDefault(t => t.Name.ToLower().Equals(classname.ToLower()))
                .GetMethods().FirstOrDefault(m => m.Name.ToLower().Equals(method))), value1, value2));

            return this;
        }
    }
}
