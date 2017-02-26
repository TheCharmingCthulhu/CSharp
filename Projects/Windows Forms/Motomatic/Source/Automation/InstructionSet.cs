using System;
using System.Collections.Generic;

namespace Motomatic.Source.Automation
{
    class InstructionSet
    {
        List<Instruction> _Expressions = new List<Instruction>();

        public void InsertExpression(Instruction expr)
        {
            _Expressions.Add(expr);
        }

        public void RemoveExpression(string label)
        {
            _Expressions.RemoveAll(expr => expr.Expression.Method.Name.ToLower().Equals(label.ToLower()));
        }

        public void RemoveExpression(Instruction expr)
        {
            _Expressions.Remove(expr);
        }

        public void Call(string label)
        {
            _Expressions.ForEach(expr =>
            {
                if (expr.Expression.Method.Name.ToLower().Equals(label.ToLower()))
                    expr.Expression.DynamicInvoke(expr.Parameters);
            });
        }

        public void Call(int index)
        {
            if (index > -1 && index < _Expressions.Count) _Expressions[index].Expression.DynamicInvoke(_Expressions[index].Parameters);
        }

        public void CallAll()
        {
            _Expressions.ForEach(expr =>
            {
                expr.Expression.DynamicInvoke(expr.Parameters);
            });
        }
    }
}
