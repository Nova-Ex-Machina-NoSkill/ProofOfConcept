using System;
using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.TransferObject
{
    public class StudentBO
    {
        private List<StudentVO> students;

        public List<StudentVO> Students { get { return students; } }

        public StudentBO()
        {
            students = new List<StudentVO>();
            var s1 = new StudentVO("Thomas", 0);
            var s2 = new StudentVO("Aga", 1);
            students.Add(s1);
            students.Add(s2);
        }

        public void DeleteStudent(StudentVO student)
        {
            students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.RollNo + ", deleted from database!");
        }

        public StudentVO GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(StudentVO student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + ", updated in the database!");
        }
    }
}
