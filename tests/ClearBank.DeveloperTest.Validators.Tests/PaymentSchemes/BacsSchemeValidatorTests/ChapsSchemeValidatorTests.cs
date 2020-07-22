using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.BacsSchemeValidatorTests
{
    [Trait("Category", "Bacs Scheme Validator Tests")]
    public class BacsSchemeValidatorTests : PaymentSchemeValidationTestBase
    {
        protected readonly BacsSchemeValidator _bacsSchemeValidator;

        protected override PaymentSchemeValidator PaymentSchemeValidator => _bacsSchemeValidator;

        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.Bacs;

        public BacsSchemeValidatorTests()
            => _bacsSchemeValidator = new BacsSchemeValidator();
    }
}
