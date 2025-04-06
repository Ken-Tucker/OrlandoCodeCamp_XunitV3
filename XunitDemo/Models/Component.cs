namespace XunitDemo.Models
{
    public class Component : IComponent
    {
        public IDependency1 Dependency1 { get; set; }
        public NonInterfaceDependency NonInterfaceDependency { get; set; }
    }
}
