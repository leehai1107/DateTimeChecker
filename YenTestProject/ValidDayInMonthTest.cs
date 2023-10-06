using DayTimeCheckerWinApp;

namespace YenTestProject.nUnitTest
{
    public class ValidDayInMonthTest
    {
        DateTimeChecker dateTimeChecker;
        [SetUp]
        public void Setup()
        {
            dateTimeChecker = new DateTimeChecker();
        }

        [Test]
        public void UTCI01()
        {
            Assert.AreEqual(31, dateTimeChecker.DayInMonth(2020, 1));
        }

        [Test]
        public void UTCI02()
        {
            Assert.AreEqual(28, dateTimeChecker.DayInMonth(2021, 2));
        }

        [Test]
        public void UTCI05()
        {
            Assert.AreEqual(31, dateTimeChecker.DayInMonth(2021, 3));
        }

    }
}