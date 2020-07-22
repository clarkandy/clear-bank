using ClearBank.DeveloperTest.Domain.Payments;
using System;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationHandlerTests.IsPaymentValid
{
    public class CannotCheckIfPaymentIsValidWhenAcountNull : PaymentSchemeValidationHandlerTestBase
    {
        [Fact(DisplayName = "Cannot Check If Payment Is Valid When Account Null")]
        public void Test()
            => Assert.Throws<ArgumentNullException>(() => _paymentSchemeValidationHandler.IsPaymentValid(new MakePaymentRequest(), null));
    }
}
