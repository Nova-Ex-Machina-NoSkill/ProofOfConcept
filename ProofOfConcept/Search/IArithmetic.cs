namespace ProofOfConcept.Search
{
    public interface IArithmetic<T>
    {
        int Add(T t);

        int Subtract(T t);

        int Multiply(T t);

        int Divide(T t);
    }
}