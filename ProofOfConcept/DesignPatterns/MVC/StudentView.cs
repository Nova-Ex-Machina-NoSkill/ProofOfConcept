using System;

namespace ProofOfConcept.DesignPatterns.MVC
{
    public class StudentView
    {
        public void PrintStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine($"Student: {studentName}, Roll No: {studentRollNo}");
        }
    }
}
