using XunitDemo.Fixture;
using XunitDemo.Models;
[assembly: AssemblyFixture(typeof(JsonDataFixture))]
namespace XunitDemo.Fixture
{
    public class JsonDataFixture : IDisposable
    {
        public JsonDataFixture()
        {
            NorthWindData = System.Text.Json.JsonSerializer.Deserialize<Northwind>(
                System.IO.File.ReadAllText(
                        "Data/northwind.json"
                )
            ) ?? new Northwind();
        }

        public void Dispose()
        {
            NorthWindData = new Northwind(); // Free the managed resources if needed
        }

        public Northwind NorthWindData { get; set; }
    }
}
