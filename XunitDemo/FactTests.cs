using Caliburn.Micro.Extensions;
using XunitDemo.BeforeAndAfter;
using XunitDemo.Orderers;

[assembly: CaptureConsole]

namespace XunitDemo
{
    [TestCaseOrderer(typeof(AlphabeticalOrderer))]
    public class FactTests
    {
        [Fact]
        [TestBeforeAfter]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void IsPrime()
        {
            var prime = new PrimeNumber();
            Assert.True(prime.IsPrimeNumber(5));
        }


    }
}
