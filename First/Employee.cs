using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace First
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room RoomNumber { get; set; }

        public Employee(string Name, string BirthDate, Genders gender, int Salary, string Profession, Room RoomNumber) : base(Name, BirthDate, gender)
        {
            this.Salary = Salary;
            this.Profession = Profession;
            this.RoomNumber = RoomNumber;
    }

        public override string ToString()
        {
            if (gender == Genders.Male)
            {
                return String.Format("This person name is {0}. He was born in {1} with {2} gender. He's working as {3} and earning {4} yearly",
                    Name, BirthDate, Genders.Male, Profession, Salary);
            }
            else
            {
                return String.Format("This person name is {0}. She was born in {1} with {2} gender. She's working as {3} and earning {4} yearly",
                    Name, BirthDate, Genders.Female, Profession, Salary);
            }
        }
    }
}
