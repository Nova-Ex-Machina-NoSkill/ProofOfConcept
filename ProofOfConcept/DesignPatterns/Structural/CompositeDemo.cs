namespace ProofOfConcept.DesignPatterns.Structural
{
    using Composite;

    public class CompositeDemo
    {
        public static void TestComposite()
        {
            var ceo = new Employee("Thomas Frost", "CEO", 1337);
            var sales = new Employee("Chase", "Sales", 3000);
            var s1 = new Employee("Robert", "Sales", 2500);
            var s2 = new Employee("Michael", "Sales", 2750);
            var marketing = new Employee("Lisa", "Marketing", 4000);
            var m1 = new Employee("Janet", "Marketing", 1000);
            var m2 = new Employee("Jacson", "Marketing", 1500);
            ceo.Add(sales);
            ceo.Add(marketing);
            sales.Add(s1);
            sales.Add(s2);
            marketing.Add(m1);
            marketing.Add(m2);
            System.Console.WriteLine(ceo.ToString());
            foreach (Employee e in sales.Subordinates) System.Console.WriteLine(e.ToString());
            foreach (Employee e in marketing.Subordinates) System.Console.WriteLine(e.ToString());
        }
    }
}