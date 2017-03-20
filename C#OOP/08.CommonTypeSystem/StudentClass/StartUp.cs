namespace StudentClass
{
    using System;
    using Enumerations;
    class StartUp
    {
        static void Main(string[] args)
        {
            Student st = new Student("Ivan", "Ivanov", "Ivanov", "123456789",
                "Mladost 4, Sofia, Bulgaria", "0888888888", "i.i@abv.bg", 2,
                Specialty.Botany, Faculty.Biology, University.Oxford);
            Console.WriteLine(st.Email);
            Console.WriteLine(st.ToString());
            Console.WriteLine();

            Student st2 = st;
            Student st3 = new Student("Petar", "Petrov", "Petrov", "123321312",
                "Lyulin 18, Sofia, Bulgaria", "0999999999", "pesho@abv.bg", 2,
                Specialty.Botany, Faculty.Biology, University.Oxford);
            Console.WriteLine("Equals: {0}", st3.Equals(st));
            Console.WriteLine("== operator: {0}", st==st2);

            Console.WriteLine("HashCode: {0}", st.GetHashCode());

            Console.WriteLine();
            Console.WriteLine("Clone:");
            var st8 = st3.Clone();
            Console.WriteLine(st8.ToString());
            Console.WriteLine("Clone equals: {0}", st3.Equals(st8));
            Console.WriteLine("Clone == operator: {0}", st3 == st8);
            Console.WriteLine();
            Console.WriteLine(st.CompareTo(st3));
            Console.WriteLine();



        }
    }
}
