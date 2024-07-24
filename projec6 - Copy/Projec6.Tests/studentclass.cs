using projec6;

namespace Projec6.Tests
{
    public class Studentclass
    { 
        [Test]
        public void Test1()
        {
            //arrange
            var student1 = new Student("Mikael", "Jonathan", "Marosz");
            var student2 = new Student("Mikael", "Jonathan", "Marosz");

            //assert
            Assert.AreEqual(student1.Name, student2.Name);
        }

        [Test]
        public void Type()
        {
            //arrange
            decimal test = decimal.MaxValue;
            int test2 = int.MaxValue;

            //assert
            Assert.AreEqual(test, decimal.MaxValue);
            Assert.AreEqual(test2, 2147483647);
        }
    }
}