using XunitDemo.Fixture;

namespace XunitDemo
{
    [Collection("Northwind Collection")]
    public class EmployeeTests
    {
        private readonly JsonDataFixture _fixture;

        public EmployeeTests(JsonDataFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Employee_Count_Should_Be_Atleast_1()
        {
            // Arrange
            var northwind = _fixture.NorthWindData;
            // Act
            var count = northwind.Employee?.Length ?? 0;
            // Assert
            Assert.True(count >= 1, "There should be at least one employee in the dataset.");
        }
    }
}
