using DayTimeCheckerWinApp;
using System.Windows.Forms;

namespace PhongNUnitTest {
    public class Tests {
        DateTimeChecker date;
        [SetUp]
        public void Setup() {
            date = new DateTimeChecker();
        }

        [TestCase(29, 2, 2000)]
        public void Test_UTCID01(byte day, byte month, short year) {
            Assert.That(date.IsValidDate(day, month, year), Is.EqualTo(true));
        }

        [TestCase(29, 2, 2009)]
        public void Test_UTCID02(byte day, byte month, short year) {
            Assert.That(date.IsValidDate(day, month, year), Is.EqualTo(false));
        }

        [TestCase(31, 8, 2009)]
        public void Test_UTCID08(byte day, byte month, short year) {
            Assert.That(date.IsValidDate(day, month, year), Is.EqualTo(true));
        }

        //Check how number of days in a month


    }
}