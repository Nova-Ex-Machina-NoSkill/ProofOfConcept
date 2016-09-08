using System;

namespace ProofOfConcept.DesignPatterns
{
    using DataAccessObject;

    public class DataAccessObjectDemo
    {
        public static void TestDAO()
        {
            var studentDao = new StudentDao();

            foreach (Student s in studentDao.GetAllStudents()) Console.WriteLine($"Student: [Roll No: {s.RollNo}, Name: {s.Name}]");

            var student = studentDao.GetAllStudents()[0];
            student.Name = "Tomasz";
            studentDao.UpdateStudent(student);

            foreach (Student s in studentDao.GetAllStudents()) Console.WriteLine($"Student: [Roll No: {s.RollNo}, Name: {s.Name}]");
        }
    }
}
