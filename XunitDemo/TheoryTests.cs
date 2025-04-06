using Caliburn.Micro.Extensions;
using XunitDemo.BeforeAndAfter;

namespace XunitDemo
{

    public class TheoryTests
    {
        private readonly PrimeNumber _prime; // Instance of PrimeNumber class for testing
        public TheoryTests()
        {
_
                _prime = new PrimeNumber(); // Initialize the PrimeNumber instance in the constructor
        }


        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, true)]
        public void IsPrimeNumber(int number, bool expected)
        {
            var prime = new PrimeNumber();
            Assert.Equal(expected, prime.IsPrimeNumber(number));
        }


        [Theory]
        [MemberData(nameof(MyData))]
        [TestBeforeAfter] // Example of using a custom attribute for setup/teardown
        public void TestWithMatrixData(int number, string text)
        {
            string fullText = $"{number} {text}";
            Console.WriteLine(fullText);
            // test code
            Assert.Contains(number.ToString(), fullText);
        }

        [Theory]
        [MemberData(nameof(MyData2))]
        public void TestWithTheoryDataRows(int number, string text)
        {
            string fullText = $"{number} {text}";
            Console.WriteLine(fullText);
            // test code
            Assert.Contains(number.ToString(), fullText);
        }

        public static TheoryData<int, string> MyData =
    new MatrixTheoryData<int, string>(
        [42, 2112, 2600],
        ["Hello", "World"]
    );
        public static IEnumerable<TheoryDataRow<int, string>> MyData2 =>
            new List<TheoryDataRow<int, string>>
            {
                new TheoryDataRow<int, string>(1, "One"),
                new TheoryDataRow<int, string>(2, "Two"),
                new TheoryDataRow<int, string>(3, "Three"),
                new TheoryDataRow<int, string>(4, "Four"),
                new TheoryDataRow<int, string>(5, "Five")
            };

    }
}
