using DayTimeCheckerWinApp;

namespace Lab3_LKH_Test
{
    public class HoangTest
    {
        DateTimeChecker date;         
        [SetUp]
        public void Setup()
        {
            date = new DateTimeChecker();
        }

        [Test]
        public void CheckDate_UTCID06()
        {
            Assert.AreEqual(true, date.IsValidDate(31, 5, 2020));
        }
        [Test]
        public void CheckDate_UTCID07()
        {
            Assert.AreEqual(true, date.IsValidDate(31, 7, 2000));
        }
        [Test]
        public void CheckDate_UTCID09()
        {
            Assert.AreEqual(true, date.IsValidDate(31, 10, 2020));
        }
        [Test]
        public void DayinMonth_UTCID04()
        {
            Assert.AreEqual(28, date.DayInMonth(2010, 1));
        }
        [Test]
        public void DayinMonth_UTCID07()
        {
            Assert.AreEqual(31, date.DayInMonth(2021, 5));
        }
        [Test]
        public void DayinMonth_UTCID08()
        {
            Assert.AreEqual(31, date.DayInMonth(2010, 6));
        }
    }
}