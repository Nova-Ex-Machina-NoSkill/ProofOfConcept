namespace ProofOfConcept.DesignPatterns.MVC
{
    public class StudentController
    {
        private Student model;
        private StudentView view;

        public string Name { get { return model.Name; } set { model.Name = value; } }

        public string RollNo { get { return model.RollNo; } set { model.RollNo = value; } }

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void UpdateView()
        {
            view.PrintStudentDetails(model.Name, model.RollNo);
        }
    }
}
