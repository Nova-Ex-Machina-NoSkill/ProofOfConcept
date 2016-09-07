namespace ProofOfConcept.DesignPatterns.Behavioral.Interpreter
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
