namespace TestAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is the setup script");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}