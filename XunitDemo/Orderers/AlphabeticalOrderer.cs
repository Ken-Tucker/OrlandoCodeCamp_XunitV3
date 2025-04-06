using Xunit.Sdk;
using Xunit.v3;

namespace XunitDemo.Orderers
{
    public class AlphabeticalOrderer : ITestCaseOrderer
    {
        public IReadOnlyCollection<TTestCase> OrderTestCases<TTestCase>(IReadOnlyCollection<TTestCase> testCases)
            where TTestCase : notnull, ITestCase
        {
            var result = testCases.Cast<IXunitTestCase>().ToList();
            result.Sort((x, y) => StringComparer.OrdinalIgnoreCase.Compare(x.TestMethod.Method.Name, y.TestMethod.Method.Name));
            result.Reverse();
            return result.Cast<TTestCase>().ToArray();
        }
    }
}
