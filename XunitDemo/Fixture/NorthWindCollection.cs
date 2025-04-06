namespace XunitDemo.Fixture
{
    [CollectionDefinition("NorthWind collection")]
    public class NorthWindCollection : ICollectionFixture<JsonDataFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
