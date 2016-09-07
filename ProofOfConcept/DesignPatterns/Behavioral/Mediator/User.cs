namespace ProofOfConcept.DesignPatterns.Behavioral.Mediator
{
    public class User
    {
        private string name;

        public string Name { get { return name; } }

        public User(string name)
        {
            this.name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
