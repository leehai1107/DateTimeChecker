using DayTimeCheckerWinApp;

namespace TestProject
{
    public class HaiTest
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
            Assert.AreEqual(28,dateTimeChecker.DayInMonth(2023,2));
        }
    }
}