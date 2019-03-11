using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using First;


namespace FirstTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void ToString_TextFormated_GoodFormat()
        {
            var worm = new Employee("Worm", "10/10/1970", Genders.Male, 100000, "junior C# dev", new Room(10));
            worm.Room.RoomNumber = 10;

            string ExpectedName = "Worm";
            string ExpectedBirthDate = "10/10/1970";
            int ExpectedSalary = 100000;
            string ExpectedProfession = "junior C# dev";
            int ExpectedRoomNumber = 10;

            string expectedOutput = String.Format("This person name is {0}. He was born in {1} with {2} gender. He's working as {3} and earning {4} yearly. Room : {5}",
                    ExpectedName, ExpectedBirthDate, Genders.Male, ExpectedProfession, ExpectedSalary, ExpectedRoomNumber);

            

            Assert.AreEqual(expectedOutput, worm.ToString());
        }
    }
}