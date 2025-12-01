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
    }
}
