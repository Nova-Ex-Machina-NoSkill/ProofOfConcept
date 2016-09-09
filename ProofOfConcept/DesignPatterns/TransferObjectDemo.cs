using System;

namespace ProofOfConcept.DesignPatterns
{
    using TransferObject;

    public class TransferObjectDemo
    {
        public static void TestTransferObject()
        {
            var student = new StudentBO();

            foreach (StudentVO s in student.Students) Console.WriteLine($"Student: [RollNo: {s.RollNo}, Name: {s.Name}]");

            var st = student.Students[0];
            st.Name = "Tomasz";
            student.UpdateStudent(st);

            st = student.GetStudent(0);
            Console.WriteLine($"Student: [RollNo: {st.RollNo}, Name: {st.Name}]");
        }
    }
}
