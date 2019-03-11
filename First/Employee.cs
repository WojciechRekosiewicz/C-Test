using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace First
{
    public class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room Room;

        public Employee(string Name, string BirthDate, Genders gender, int Salary, string Profession, Room Room) : base(Name, BirthDate, gender)
        {
            this.Salary = Salary;
            this.Profession = Profession;
            this.Room = Room;
    }

        public override string ToString()
        {
            if (gender == Genders.Male)
            {
                return String.Format("This person name is {0}. He was born in {1} with {2} gender. He's working as {3} and earning {4} yearly. Room : {5}",
                    Name, BirthDate, Genders.Male, Profession, Salary, Room.RoomNumber);
            }
            else
            {
                return String.Format("This person name is {0}. She was born in {1} with {2} gender. She's working as {3} and earning {4} yearly. Room : {5}",
                    Name, BirthDate, Genders.Female, Profession, Salary, Room.RoomNumber);
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
