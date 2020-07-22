using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using Xunit;

namespace ClearBank.DeveloperTest.Validators.Tests.PaymentSchemes
{
    [Trait("Category", "Payment Scheme Validation Tests")]
    public abstract class PaymentSchemeValidationTestBase
    {
        protected Account _account;

        protected MakePaymentRequest _makePaymentRequest;

        protected abstract PaymentSchemeValidator PaymentSchemeValidator { get; }

        protected abstract AllowedPaymentSchemes AllowedPaymentSchemes { get; }

        public PaymentSchemeValidationTestBase()
        {
            _makePaymentRequest = new MakePaymentRequest();
            _account = new Account()
            {
                AllowedPaymentSchemes = AllowedPaymentSchemes
            };
        }

        [Fact]
        public void PaymentIsNotValidWhenAccountIsNull()
        {
            _account = null;
            Assert.False(PaymentSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
        }

        [Fact]
        public void PaymentIsNotValidWhenPaymentRequestIsNull()
        {
            _makePaymentRequest = null;
            Assert.False(PaymentSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
        }

        [Fact]
        public void PaymentNotValidWhenSchemeNotAllowed()
        {
            _account.AllowedPaymentSchemes--;
            Assert.False(PaymentSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
        }

        [Fact]
        public void CanDeterminePaymentIsValid()
            => Assert.True(PaymentSchemeValidator.IsPaymentValid(_account, _makePaymentRequest));
    }
}
