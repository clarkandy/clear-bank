namespace ClearBank.DeveloperTest.Domain
{
    public interface IDependencyLocator
    {
        T Resolve<T>();
    }
}
