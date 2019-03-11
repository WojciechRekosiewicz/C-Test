using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Person michaela = new Person("michaela", "29/01/1990", Genders.Female);
            Employee worm = new Employee("Robak", "10/10/1970", Genders.Male, 100000, "junior C# dev", new Room(10));

            Console.WriteLine(michaela.ToString());
            Console.WriteLine();
            Console.WriteLine(worm.ToString());
            Console.ReadLine();
        }
    }
}
