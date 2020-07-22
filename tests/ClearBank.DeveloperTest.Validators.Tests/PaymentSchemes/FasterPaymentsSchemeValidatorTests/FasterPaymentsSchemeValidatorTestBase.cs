using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.FasterPaymentsSchemeValidatorTests
{
    [Trait("Category", "Faster Payments Scheme Validator Tests")]
    public class FasterPaymentsSchemeValidatorTestBase
    {
        protected Account _account;

        protected MakePaymentRequest _makePaymentRequest;

        protected readonly FasterPaymentsSchemeValidator _fasterPaymentsSchemeValidator;

        public FasterPaymentsSchemeValidatorTestBase()
        {
            _account = new Account();
            _makePaymentRequest = new MakePaymentRequest();
            _fasterPaymentsSchemeValidator = new FasterPaymentsSchemeValidator();
        }
    }
}
