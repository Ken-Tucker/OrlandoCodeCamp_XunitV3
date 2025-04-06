using System.Reflection;
using Xunit.v3;

namespace XunitDemo.BeforeAndAfter
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class TestBeforeAfter : BeforeAfterTestAttribute
    {

        public override void Before(MethodInfo methodUnderTest, IXunitTest test)
        {
            Console.WriteLine($"Before {methodUnderTest.Name} Value ");
        }

        public override void After(MethodInfo methodUnderTest, IXunitTest test)
        {
            Console.WriteLine($"After {methodUnderTest.Name}");
        }
    }
}
