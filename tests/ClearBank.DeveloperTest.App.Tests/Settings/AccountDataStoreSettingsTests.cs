using ClearBank.DeveloperTest.App.Settings;
using ClearBank.DeveloperTest.Domain.Data;
using Xunit;

namespace ClearBank.DeveloperTest.App.Tests.Settings
{
    [Trait("Category", "Settings Tests")]
    public class AccountDataStoreSettingsTests
    {
        private readonly AccountDataStoreSettings _accountDataStoreSettings;

        public AccountDataStoreSettingsTests()
            => _accountDataStoreSettings = new AccountDataStoreSettings();

        [Fact(DisplayName = "Can Get Data Store Type From Config")]
        public void CanGetDataStoreTypeFromConfig()
            => Assert.Equal(DataStoreTypes.Main, _accountDataStoreSettings.DataStoreType);
    }
}
