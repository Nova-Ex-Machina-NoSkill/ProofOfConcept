namespace ProofOfConcept.Math
{
    public static class LCM
    {
        public static long GetLCM(long a, long b)
        {
            return (a / GCD.GetGCD(a, b)) * b;
        }
    }
}