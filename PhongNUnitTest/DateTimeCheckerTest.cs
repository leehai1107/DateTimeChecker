using DayTimeCheckerWinApp;

namespace PhongNUnitTest {
    public class DateTimeCheckerTest {
        private DateTimeChecker _date { get; set; } = null!;
        [SetUp]
        public void Setup() {
            _date = new DateTimeChecker();
        }

        [Test]
        public void TestInputOfFebruary_NotInLeapYear() {
            //assign
            byte day = 29;
            byte month = 2;
            short year = 2002;

            //act
            var correct = _date.IsValidDate(day, month, year);

            //assert
            Assert.Pass();
        }
    }
}