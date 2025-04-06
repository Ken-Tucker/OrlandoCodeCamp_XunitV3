using XunitDemo.Fixture;

namespace XunitDemo
{
    [Collection("Northwind Collection")]
    public class CategoryTests
    {
        private readonly JsonDataFixture _fixture;

        public CategoryTests(JsonDataFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Can_Load_Categories_From_Northwind()
        {
            // Arrange
            var northwind = _fixture.NorthWindData;
            // Act
            var categories = northwind.Category;
            // Assert
            Assert.NotNull(categories);
            Assert.True(categories.Length > 0, "There should be at least one category in the Northwind data.");
            Assert.All(categories, c => Assert.False(string.IsNullOrEmpty(c.categoryName), "Category name should not be empty."));
        }
    }
}
