using ClearBank.DeveloperTest.Domain;
using ClearBank.DeveloperTest.Services.PaymentSchemes;
using Moq;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationProviderTests
{
    public class PaymentSchemeValidationProviderTestBase
    {
        protected readonly Mock<IDependencyLocator> _mockDependencyLocator;

        protected readonly PaymentSchemeValidationProvider _paymentSchemeValidationProvider;

        public PaymentSchemeValidationProviderTestBase()
        {
            _mockDependencyLocator = new Mock<IDependencyLocator>(MockBehavior.Strict);
            _paymentSchemeValidationProvider = new PaymentSchemeValidationProvider(_mockDependencyLocator.Object);
        }
    }
}
