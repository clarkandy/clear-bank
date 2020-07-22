using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using ClearBank.DeveloperTest.Services.Payments;
using Moq;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.Payments.PaymentServiceTests
{
    [Trait("Category", "Payment Service Tests")]
    public abstract class PaymentServiceTestBase
    {
        protected readonly Mock<IAccountDataStore> _mockAccountDataStore;

        protected readonly Mock<IPaymentSchemeValidationHandler> _mockPaymentSchemeValidationHandler;

        protected readonly PaymentService _paymentService;

        public PaymentServiceTestBase()
        {
            _mockAccountDataStore = new Mock<IAccountDataStore>(MockBehavior.Strict);
            _mockPaymentSchemeValidationHandler = new Mock<IPaymentSchemeValidationHandler>(MockBehavior.Strict);
            _paymentService = new PaymentService(_mockAccountDataStore.Object, _mockPaymentSchemeValidationHandler.Object);
        }
    }
}
