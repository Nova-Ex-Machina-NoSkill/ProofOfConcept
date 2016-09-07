namespace ProofOfConcept.DesignPatterns.Creational
{
    public class SingletonDemo
    {

        public static void TestSingleton()
        {
            // Error - private constructor!
            //var s = new Singleton.SingleObject();

            var s = Singleton.SingleObject.GetInstance();
            System.Console.WriteLine(s.ToString());
        }
    }
}