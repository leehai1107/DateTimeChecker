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
        public void UTCID13()
        {
            Assert.AreEqual(false,dateTimeChecker.IsValidDate(31,6,2000));
        }

        [Test]
        public void UTCID14()
        {
            Assert.AreEqual(true, dateTimeChecker.IsValidDate(30, 6, 2000));
        }

        [Test]
        public void UTCID15()
        {
            Assert.AreEqual(false, dateTimeChecker.IsValidDate(31, 9, 2020));
        }

        [Test]
        public void UTCID13_DayInMonth()
        {
            Assert.AreEqual(30, dateTimeChecker.DayInMonth(2021, 11));
        }
        
        [Test]
        public void UTCID14_DayInMonth()
        {
            Assert.AreEqual(31, dateTimeChecker.DayInMonth(2010, 12));
        }
    }
}