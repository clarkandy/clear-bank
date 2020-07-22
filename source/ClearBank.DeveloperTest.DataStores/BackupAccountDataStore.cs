using ClearBank.DeveloperTest.Domain.Accounts;
using System;

namespace ClearBank.DeveloperTest.DataStores
{
    public class BackupAccountDataStore : IAccountDataStore
    {
        public Account GetAccount(string accountNumber)
            => throw new NotImplementedException();

        public void UpdateAccount(Account account)
            => throw new NotImplementedException();
    }
}
