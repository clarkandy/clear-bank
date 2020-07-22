using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using ClearBank.DeveloperTest.Services.PaymentSchemes;
using Moq;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationHandlerTests
{
    [Trait("Category", "Payment Scheme Validation Handler Tests")]
    public abstract class PaymentSchemeValidationHandlerTestBase
    {
        protected readonly Mock<IPaymentSchemeValidationProvider> _mockPaymentSchemeValidationProvider;

        protected readonly PaymentSchemeValidationHandler _paymentSchemeValidationHandler;

        public PaymentSchemeValidationHandlerTestBase()
        {
            _mockPaymentSchemeValidationProvider = new Mock<IPaymentSchemeValidationProvider>(MockBehavior.Strict);
            _paymentSchemeValidationHandler = new PaymentSchemeValidationHandler(_mockPaymentSchemeValidationProvider.Object);
        }
    }
}
