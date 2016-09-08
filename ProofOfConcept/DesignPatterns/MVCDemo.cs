namespace ProofOfConcept.DesignPatterns
{
    using MVC;

    public class MVCDemo
    {
        public static void TestMVC()
        {
            var model = retriveStudentFromDatabase();
            var view = new StudentView();
            var controller = new StudentController(model, view);

            controller.UpdateView();

            controller.Name = "Aga";

            controller.UpdateView();
        }

        private static Student retriveStudentFromDatabase()
        {
            var student = new Student();
            student.Name = "Thomas";
            student.RollNo = "23";
            return student;
        }
    }
}
