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
            Person mike = new Person("Mike", "29/01/1990", Genders.Male);

            Console.WriteLine(mike.ToString());
            Console.ReadLine();
        }
    }
}
