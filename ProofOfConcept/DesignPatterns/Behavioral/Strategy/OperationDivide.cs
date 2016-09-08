using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Strategy
{
    public class OperationDivide : IStrategy
    {
        public int DoOperation(int x, int y)
        {
            if (y != 0) return x / y;
            else throw new DivideByZeroException();
        }
    }
}
