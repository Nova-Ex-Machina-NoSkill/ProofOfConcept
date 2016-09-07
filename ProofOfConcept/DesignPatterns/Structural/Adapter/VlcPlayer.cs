using System;

namespace ProofOfConcept.DesignPatterns.Structural.Adapter
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName) { }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing VLC: " + fileName);
        }
    }
}
