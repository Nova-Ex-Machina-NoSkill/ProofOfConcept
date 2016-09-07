namespace ProofOfConcept.DesignPatterns.Structural.Adapter
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);

        void PlayMp4(string fileName);
    }
}
