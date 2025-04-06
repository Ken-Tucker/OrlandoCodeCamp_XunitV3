using Caliburn.Micro.Extensions;
using Moq;
using XunitDemo.BeforeAndAfter;

namespace XunitDemo
{
    public class SkipTests
    {
        [Theory]
        [TestBeforeAfter]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        public void IsPrimeNumberSkip(int number, bool expected)
        {
            //var prime = new PrimeNumber();
            var mockPrime = new Mock<PrimeNumber>();
            mockPrime.Setup(x => x.IsPrimeNumber(It.IsAny<int>()))
                .Returns((int n) => n != 4);
            var prime = mockPrime.Object;// Mocking to return false for 4
            Assert.SkipWhen(number == 4, "Skipping test for number 4 as it is not prime");
            Assert.Equal(expected, prime.IsPrimeNumber(number));
        }

        [Theory]
        [MemberData(nameof(PrimeDataRows))]
        public void IsPrimeNumberSkipDataRow(int number, bool expected)
        {
            var prime = new PrimeNumber();
            Assert.Equal(expected, prime.IsPrimeNumber(number));
        }

        public static IEnumerable<TheoryDataRow<int, bool>> PrimeDataRows =>
    new List<TheoryDataRow<int, bool>>
    {
                new TheoryDataRow<int, bool>(2, true),
                new TheoryDataRow<int, bool>(3, true),
                new TheoryDataRow<int, bool>(4, false).WithSkip("Theory Data Row skipped 4 not prime"),
                new TheoryDataRow<int, bool>(5, true),
                new TheoryDataRow<int, bool>(6, false)
    };
    }
}
