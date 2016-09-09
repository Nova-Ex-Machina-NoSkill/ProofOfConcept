namespace ProofOfConcept.DesignPatterns.FrontController
{
    public class Dispatcher
    {
        private StudentView studentView;
        private HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if (request.ToUpper() == "STUDENT") studentView.Show();
            else if (request.ToUpper() == "HOME") homeView.Show();
        }
    }
}
