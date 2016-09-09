namespace ProofOfConcept.DesignPatterns
{
    using FrontController;

    public class FrontControllerDemo
    {
        public static void TestFrontController()
        {
            var frontController = new FrontController.FrontController();
            frontController.DispatchRequest("HOME");
            frontController.DispatchRequest("STUDENT");
        }
    }
}
