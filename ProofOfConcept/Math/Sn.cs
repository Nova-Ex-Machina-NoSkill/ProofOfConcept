namespace ProofOfConcept.Math
{
    public static class Sn
    {
        public static long GetSn(long firstElement, long amountOfElements)
        {
            return ((firstElement + (amountOfElements * firstElement)) * amountOfElements) / 2;
        }
    }
}
