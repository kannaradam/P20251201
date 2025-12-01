using NUnit.Framework.Legacy;

namespace P20251201
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            
            StringAssert.Contains("@","Pelda@valami.hu");

        }
        public void Test2()
        {
            //Assert.Pass();

            StringAssert.Contains("@", "Peldavalami.hu");

        }
        public void Test3()
        {
            //Assert.Pass();

            StringAssert.Contains(".", "Pelda@valami.hu");

        }
        public void Test4()
        {
            //Assert.Pass();

            ClassicAssert.Equals(1,2);

        }
    }
}
