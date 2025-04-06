namespace XunitDemo.Models
{
    public class EnumerableDependency1 : IEnumerableDependency
    {
        public IDependency2 Dependency2 { get; set; }
    }
}
