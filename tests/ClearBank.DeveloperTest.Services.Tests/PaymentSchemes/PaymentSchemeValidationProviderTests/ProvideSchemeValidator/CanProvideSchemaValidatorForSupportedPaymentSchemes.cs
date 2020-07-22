using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using Moq;
using System;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.PaymentSchemes.PaymentSchemeValidationProviderTests.ProvideSchemeValidator
{
    public class CanProvideSchemaValidatorForSupportedPaymentSchemes : PaymentSchemeValidationProviderTestBase
    {
        public CanProvideSchemaValidatorForSupportedPaymentSchemes()
        {
            _mockDependencyLocator.Setup(l => l.Resolve<IFasterPaymentsSchemeValidator>()).Returns(Mock.Of<IFasterPaymentsSchemeValidator>());
            _mockDependencyLocator.Setup(l => l.Resolve<IBacsSchemeValidator>()).Returns(Mock.Of<IBacsSchemeValidator>());
            _mockDependencyLocator.Setup(l => l.Resolve<IChapsSchemeValidator>()).Returns(Mock.Of<IChapsSchemeValidator>());
        }

        [InlineData(PaymentScheme.FasterPayments, typeof(IFasterPaymentsSchemeValidator))]
        [InlineData(PaymentScheme.Bacs, typeof(IBacsSchemeValidator))]
        [InlineData(PaymentScheme.Chaps, typeof(IChapsSchemeValidator))]
        [Theory(DisplayName = "Can Provide Schema Validator For Supported Payment Schemes")]
        public void Test(PaymentScheme paymentScheme, Type expectedType)
            => Assert.IsAssignableFrom(expectedType, _paymentSchemeValidationProvider.ProvideSchemeValidator(paymentScheme));
    }
}
