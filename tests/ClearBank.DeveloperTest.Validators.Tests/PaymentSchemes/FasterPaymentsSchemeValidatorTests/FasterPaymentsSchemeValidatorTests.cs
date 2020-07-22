using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes.FasterPaymentsSchemeValidatorTests
{
    [Trait("Category", "Faster Payments Scheme Validator Tests")]
    public class FasterPaymentsSchemeValidatorTests : PaymentSchemeValidationTestBase
    {
        protected readonly FasterPaymentsSchemeValidator _chapsSchemeValidator;

        protected override PaymentSchemeValidator PaymentSchemeValidator => _chapsSchemeValidator;

        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.FasterPayments;

        public FasterPaymentsSchemeValidatorTests()
        {
            _chapsSchemeValidator = new FasterPaymentsSchemeValidator();
            _account.Balance = 10;
            _makePaymentRequest.Amount = 5;
        }
    }
}
