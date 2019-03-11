using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First.UnitTests
{
    [TestClass]
    public class EmployeeTests
    {
       
        enum Genders { Male, Female }

        [TestMethod]
        public void ToString_GenderMale_ReturnString()
        {
            var testEmployee = new Employee("Robak", "10/10/1970", Genders.Male, 100000, "junior C# dev", new Room(10));
        }
    }
}
