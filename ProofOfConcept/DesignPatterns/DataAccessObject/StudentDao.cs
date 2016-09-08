using System;
using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.DataAccessObject
{
    public class StudentDao : IStudentDao
    {
        private List<Student> students;

        public StudentDao()
        {
            students = new List<Student>();
            var s1 = new Student("Thomas", 1);
            var s2 = new Student("Aga", 2);
            students.Add(s1);
            students.Add(s2);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.RollNo + ", deleted from the database!");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            students[student.RollNo].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.RollNo + ", updated in the database!");
        }
    }
}
