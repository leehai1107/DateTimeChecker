using DayTimeCheckerWinApp;

namespace TestProject
{
    public class Tests
    {

        [TestFixture]
        public class DateTimeCheckerTests
        {
            private DateTimeChecker dateTimeChecker;

            [SetUp]
            public void Setup()
            {
                dateTimeChecker = new DateTimeChecker();
            }



            [Test]
            public void CheckDate_UTCID010()
            {
                Assert.AreEqual(false, dateTimeChecker.IsValidDate(31, 12, 2000));
            }

            [Test]
            public void CheckDate_UTCID011()
            {
                Assert.AreEqual(false, dateTimeChecker.IsValidDate(31, 4, 2000));
            }

            [Test]
            public void CheckDate_UTCID012()
            {
                Assert.AreEqual(false, dateTimeChecker.IsValidDate(30, 4, 2020));
            }

            [Test]
            public void DayInMonth_UTCID010()//bug
            {
                Assert.AreEqual(31, dateTimeChecker.DayInMonth(8,10));
            }

            [Test]
            public void DayInMonth_UTCID011()
            {
                Assert.AreEqual(30, dateTimeChecker.DayInMonth(2021, 9));
            }

            [Test]
            public void DayInMonth_UTCID012()
            {
                Assert.AreEqual(31, dateTimeChecker.DayInMonth(2020, 10));
            }
        }

    }
}