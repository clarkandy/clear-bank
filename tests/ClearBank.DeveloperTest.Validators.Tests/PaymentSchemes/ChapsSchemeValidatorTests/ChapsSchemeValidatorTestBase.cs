using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.ChapsSchemeValidatorTests
{
    [Trait("Category", "Chaps Scheme Validator Tests")]
    public class ChapsSchemeValidatorTestBase
    {
        protected Account _account;

        protected MakePaymentRequest _makePaymentRequest;

        protected readonly ChapsSchemeValidator _chapsSchemeValidator;

        public ChapsSchemeValidatorTestBase()
        {
            _account = new Account();
            _makePaymentRequest = new MakePaymentRequest();
            _chapsSchemeValidator = new ChapsSchemeValidator();
        }
    }
}
