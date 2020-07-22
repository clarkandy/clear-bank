﻿
namespace ClearBank.DeveloperTest.Domain.Accounts
{
    public interface IAccountDataStore
    {
        Account GetAccount(string accountNumber);
        void UpdateAccount(Account account);
    }
}
