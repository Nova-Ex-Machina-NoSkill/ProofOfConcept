using System;

namespace ProofOfConcept.DesignPatterns.Structural.Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing MP4: " + fileName);
        }

        public void PlayVlc(string fileName) { }
    }
}
