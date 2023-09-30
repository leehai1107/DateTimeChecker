using DayTimeCheckerWinApp;

namespace TestProject
{
    public class Tests
    {
        DateTimeChecker dateTimeChecker;
        [SetUp]
        public void Setup()
        {
            dateTimeChecker = new DateTimeChecker();
        }

        [Test]
        public void Test1()
        {
            
            Assert.AreEqual(29,dateTimeChecker.DayInMonth(2023,2));
        }
    }
}