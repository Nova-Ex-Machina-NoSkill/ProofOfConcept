using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.DesignPatterns.Structural
{
    using Filter;

    public class FilterDemo
    {
        public static void TestFilter()
        {
            var persons = new List<Person>();

            persons.Add(new Person("Thomas", "Male", "Single"));
            persons.Add(new Person("Aga", "Female", "Single"));
            persons.Add(new Person("James", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            print(male.MeetCriteria(persons));

            Console.WriteLine("Females: ");
            print(female.MeetCriteria(persons));

            Console.WriteLine("Single Males: ");
            print(singleMale.MeetCriteria(persons));

            Console.WriteLine("Single or Female: ");
            print(singleOrFemale.MeetCriteria(persons));
        }

        private static void print(List<Person> persons)
        {
            foreach (Person p in persons) Console.WriteLine($"{p.Name}, {p.Gender}, {p.MaritalStatus}");
        }
    }
}
