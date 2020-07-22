using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using Moq;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationHandlerTests.IsPaymentValid
{
    public class CanCheckPaymentIsValid : PaymentSchemeValidationHandlerTestBase
    {
        private readonly Mock<IPaymentSchemeValidator> _mockPaymentSchemeValidator;

        private readonly Account _account;

        private readonly MakePaymentRequest _paymentRequest;

        public CanCheckPaymentIsValid()
        {
            _account = new Account();
            _paymentRequest = new MakePaymentRequest()
            {
                PaymentScheme = PaymentScheme.Bacs
            };
            _mockPaymentSchemeValidator = new Mock<IPaymentSchemeValidator>(MockBehavior.Strict);
            _mockPaymentSchemeValidator.Setup(v => v.IsPaymentValid(_account, _paymentRequest)).Returns(true);
            _mockPaymentSchemeValidationProvider.Setup(v => v.ProvideSchemeValidator(_paymentRequest.PaymentScheme)).Returns(_mockPaymentSchemeValidator.Object);
        }

        [Fact]
        public void Test()
        {
            bool result = _paymentSchemeValidationHandler.IsPaymentValid(_paymentRequest, _account);

            Assert.True(result);
            _mockPaymentSchemeValidator.Verify(v => v.IsPaymentValid(_account, _paymentRequest), Times.Once);
            _mockPaymentSchemeValidationProvider.Verify(v => v.ProvideSchemeValidator(_paymentRequest.PaymentScheme), Times.Once);
        }
    }
}
