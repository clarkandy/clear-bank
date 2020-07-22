using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.ChapsSchemeValidatorTests.IsPaymentValid
{
    public class PaymentNotValidWhenAccountNotLive : ChapsSchemeValidatorTestBase
    {
        public PaymentNotValidWhenAccountNotLive()
            => _account.Status = AccountStatus.Disabled;

        [Fact(DisplayName = "Payment Not Valid When Account Not Live")]
        public void Test()
            => Assert.False(_chapsSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
    }
}
