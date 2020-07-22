using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Data;
using System;
using System.Configuration;

namespace ClearBank.DeveloperTest.App.Settings
{
    public class AccountDataStoreSettings : IAccountDataStoreSettings
    {
        public DataStoreTypes DataStoreType => GetAppSettingEnum<DataStoreTypes>($"{nameof(AccountDataStoreSettings)}:{nameof(DataStoreType)}");

        private T GetAppSettingEnum<T>(string key) where T : Enum
            => (T)Enum.Parse(typeof(T), ConfigurationManager.AppSettings[key]);

        private T GetAppSetting<T>(string key)
            => (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
    }
}
