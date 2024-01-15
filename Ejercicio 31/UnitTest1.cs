using Ejercicio_31;
namespace UnitTestingEx31Eric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodNumber()
        {
            //Arrange

            int number = 250;

            //Act
            int result = Program.NumbreRang(ref number);


            //Assert
            Assert.AreEqual(250, result);
            Assert.IsTrue(number >= 1 && number <= 500);


        }

        [TestMethod]
        public void TestMethodPersonatge()
        {
            //Arrange

            string name = "Arquera";


            //Act
            string result = Program.NameRang(ref name);


            //Assert
            Assert.AreEqual("Arquera", result);
            Assert.IsTrue(name.Length <= 10);


        }


        [TestMethod]
        public void TestMethodRandom()
        {
            //Arrange

            int result = Program.GenerateRandomNumber();




            //Assert
            Assert.IsTrue(result >= 1 && result <= 100);


        }
    }
}