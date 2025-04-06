namespace XunitDemo.Models
{
    public class Dependency1 : IDependency1
    {
        public Dependency1()
        {
        }

        public IDependency2 Dependency2 { get; set; }
        public IList<IEnumerableDependency> EnumerableDependencies { get; set; }
    }
}
