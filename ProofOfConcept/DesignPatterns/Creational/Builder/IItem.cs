namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }
}