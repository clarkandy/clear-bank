using ClearBank.DeveloperTest.Domain.Accounts;
using System;

namespace ClearBank.DeveloperTest.DataStores
{
    public class AccountDataStore : IAccountDataStore
    {
        public Account GetAccount(string accountNumber)
            => throw new NotImplementedException();

        public void UpdateAccount(Account account)
            => throw new NotImplementedException();
    }
}
