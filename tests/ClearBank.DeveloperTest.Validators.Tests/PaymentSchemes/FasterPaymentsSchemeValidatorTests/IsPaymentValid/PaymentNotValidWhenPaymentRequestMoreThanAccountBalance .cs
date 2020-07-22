using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.FasterPaymentsSchemeValidatorTests.IsPaymentValid
{
    public class PaymentNotValidWhenPaymentRequestMoreThanAccountBalance : FasterPaymentsSchemeValidatorTestBase
    {
        public PaymentNotValidWhenPaymentRequestMoreThanAccountBalance()
            => _account.Balance = 1;

        [Fact(DisplayName = "Payment Not Valid When Payment Request More Than Account Balance")]
        public void Test()
            => Assert.False(_fasterPaymentsSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
    }
}
