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
            Employee worm = new Employee("Robak", "10/10/1970", Genders.Male, 100000, "junior C# dev", new Room());
            worm.Room.RoomNumber = 10;

            Console.WriteLine();
            Console.WriteLine(worm.ToString());

            Employee worm2 = (Employee)worm.Clone();
            worm2.Room.RoomNumber = 101;
            Console.WriteLine(worm2.ToString());
            Console.ReadKey();
        }
    }
}
