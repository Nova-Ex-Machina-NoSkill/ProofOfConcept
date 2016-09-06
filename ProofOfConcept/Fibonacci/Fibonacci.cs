namespace ProofOfConcept.Fibonacci
{
    public static class Fibonacci
    {
        public static int GetFibonacci(int f1, int f2, int step)
        {
            var fib = 0;
            for(var i = 0; i < step; i++)
            {
                fib = f1 + f2;
                f1 = f2;
                f2 = fib;
            }
            return fib;
        }

        public static int GetFibonacciRecursive(int f1, int f2, int step)
        {
            if (step > 0) return GetFibonacciRecursive(f2, f1 + f2, --step);
            else return f1 + f2;
        }
    }
}