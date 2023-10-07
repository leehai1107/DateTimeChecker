using DayTimeCheckerWinApp;

namespace YenTestProject.nUnitTest
{
    public class DateTimeCheckerTest
    {
        DateTimeChecker dateTimeChecker;
        [SetUp]
        public void Setup()
        {
            dateTimeChecker = new DateTimeChecker();
        }

        [Test]
        public void UTCID01()
        {
            Assert.AreEqual(31, dateTimeChecker.DayInMonth(2020, 1));
        }

        [Test]
        public void UTCID02()
        {
            Assert.AreEqual(28, dateTimeChecker.DayInMonth(2021, 2));
        }

        [Test]
        public void UTCID05()
        {
            Assert.AreEqual(31, dateTimeChecker.DayInMonth(2021, 3));
        }

        [TestCase(31,2,2020)]
        public void UTCID03(byte day, byte month, short year)
        {
            Assert.AreEqual(false, dateTimeChecker.IsValidDate(day, month, year));
        }

        [TestCase(31, 1, 2000)]
        public void UTCID04(byte day, byte month, short year)
        {
            Assert.AreEqual(true, dateTimeChecker.IsValidDate(day, month, year));
        }

        [TestCase(31, 3, 2009)]
        public void UTCID05_ValidDate(byte day, byte month, short year)
        {
            Assert.AreEqual(true, dateTimeChecker.IsValidDate(day, month, year));
        }
    }
}