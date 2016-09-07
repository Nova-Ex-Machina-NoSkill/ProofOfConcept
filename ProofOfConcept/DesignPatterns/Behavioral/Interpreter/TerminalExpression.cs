using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.DesignPatterns.Behavioral.Interpreter
{
    public class TerminalExpression : IExpression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(data)) return true;
            else return false;
        }
    }
}
