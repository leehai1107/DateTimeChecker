using DayTimeCheckerWinApp;

namespace PhongTestProject {
    public class PhongTest {
        DateTimeChecker date;
        [SetUp]
        public void Setup() {
            date = new DateTimeChecker();
        }

        [TestCase(29, 2, 2000)]
        public void Test1_UTCID01(byte day, byte month, short year) {
            Assert.AreEqual(true, date.IsValidDate(day, month, year));
        }

        [TestCase(29, 2, 2009)]
        public void Test1_UTCID02(byte day, byte month, short year) {
            Assert.AreEqual(false, date.IsValidDate(day, month, year));
        }

        [TestCase(31, 8, 2009)]
        public void Test1_UTCID08(byte day, byte month, short year) {
            Assert.AreEqual(true, date.IsValidDate(day, month, year));
        }

        [TestCase(2019, 2)]
        public void Test2_UTCID03(short year, byte month) {
            Assert.AreEqual(28, date.DayInMonth(year, month));
        }

        [TestCase(2020, 4)]
        public void Test2_UTCID06(short year, byte month) {
            Assert.AreEqual(30, date.DayInMonth(year, month));
        }

        [TestCase(2019, 7)]
        public void Test2_UTCID09(short year, byte month) {
            Assert.AreEqual(31, date.DayInMonth(year, month));
        }
    }
}