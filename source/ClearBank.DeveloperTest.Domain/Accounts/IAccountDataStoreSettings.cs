using ClearBank.DeveloperTest.Domain.Data;

namespace ClearBank.DeveloperTest.Domain.Accounts
{
    public interface IAccountDataStoreSettings
    {
        DataStoreTypes DataStoreType { get; }
    }
}
