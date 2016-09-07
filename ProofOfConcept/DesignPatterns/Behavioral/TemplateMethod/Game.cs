namespace ProofOfConcept.DesignPatterns.Behavioral.TemplateMethod
{
    abstract public class Game
    {
        protected abstract void initialize();

        protected abstract void startPlay();

        protected abstract void endPlay();

        public void Play()
        {
            initialize();
            startPlay();
            endPlay();
        }
    }
}
