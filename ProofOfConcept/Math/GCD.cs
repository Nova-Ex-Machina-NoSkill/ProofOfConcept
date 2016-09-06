namespace ProofOfConcept.Math
{
    public static class GCD
    {
        public static long GetGCD(long a, long b)
        {
            while(b != 0)
            {
                var tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
    }
}