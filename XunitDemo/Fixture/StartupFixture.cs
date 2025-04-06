using Xunit.Sdk;
using Xunit.v3;
using XunitDemo.Fixture;
[assembly: TestPipelineStartup(typeof(StartupFixture))]
namespace XunitDemo.Fixture
{
    public class StartupFixture : ITestPipelineStartup
    {
        public async Task StartAsync()
        {
            await Task.CompletedTask; // This method is required by the interface but can be empty in this case.
        }

        public async ValueTask StartAsync(IMessageSink diagnosticMessageSink)
        {
            Console.WriteLine("Test pipeline starting...");
            await Task.CompletedTask;
        }

        public async ValueTask StopAsync()
        {
            Console.WriteLine("Test pipeline stopping...");
            await Task.CompletedTask;
        }
    }
}
