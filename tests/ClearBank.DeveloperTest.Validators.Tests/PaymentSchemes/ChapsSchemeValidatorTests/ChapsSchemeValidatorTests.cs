using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.ChapsSchemeValidatorTests
{
    [Trait("Category", "Chaps Scheme Validator Tests")]
    public class ChapsSchemeValidatorTests : PaymentSchemeValidationTestBase
    {
        protected readonly ChapsSchemeValidator _chapsSchemeValidator;

        protected override PaymentSchemeValidator PaymentSchemeValidator => _chapsSchemeValidator;

        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.Chaps;

        public ChapsSchemeValidatorTests()
        {
            _chapsSchemeValidator = new ChapsSchemeValidator();
            _account.Status = AccountStatus.Live;
        }
    }
}
