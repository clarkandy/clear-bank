using ClearBank.DeveloperTest.Domain.Accounts;
using System;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationHandlerTests.IsPaymentValid
{
    public class CannotCheckIfPaymentIsValidWhenRequestNull : PaymentSchemeValidationHandlerTestBase
    {
        [Fact(DisplayName = "Cannot Check If Payment Is Valid When Request Null")]
        public void Test()
            => Assert.Throws<ArgumentNullException>(() => _paymentSchemeValidationHandler.IsPaymentValid(null, new Account()));
    }
}
