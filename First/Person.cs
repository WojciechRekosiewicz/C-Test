using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    enum Genders { Male, Female }

    class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public Genders gender { get; set; }
        //public var Gender { get; set; }

        public Person(string Name, string BirthDate, Genders gender)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.gender = gender;
    }


        public override string ToString()
        {
           if (gender == Genders.Male)
           {
                return String.Format("This person name is {0}. He was born in {1} with {2} gender.", Name, BirthDate, Genders.Male);
           }
           else
           {
               return String.Format("This person name is {0}. She was born in {1} with {2} gender.", Name, BirthDate, Genders.Female);
           }
        }

    }
}
