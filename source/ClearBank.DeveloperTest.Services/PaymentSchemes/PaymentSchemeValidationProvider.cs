using ClearBank.DeveloperTest.Domain;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using System;

namespace ClearBank.DeveloperTest.Services.PaymentSchemes
{
    public class PaymentSchemeValidationProvider : IPaymentSchemeValidationProvider
    {
        private readonly IDependencyLocator _dependencyLocator;

        public PaymentSchemeValidationProvider(IDependencyLocator dependencyLocator)
            => _dependencyLocator = dependencyLocator;

        public IPaymentSchemeValidator ProvideSchemeValidator(PaymentScheme paymentScheme)
        {
            switch (paymentScheme)
            {
                case PaymentScheme.FasterPayments:
                    return _dependencyLocator.Resolve<IFasterPaymentsSchemeValidator>();
                case PaymentScheme.Bacs:
                    return _dependencyLocator.Resolve<IBacsSchemeValidator>();
                case PaymentScheme.Chaps:
                    return _dependencyLocator.Resolve<IChapsSchemeValidator>();
                default:
                    throw new NotSupportedException($"Payment Scheme: {paymentScheme} is not suported by the {nameof(PaymentSchemeValidationProvider)}");
            }
        }
    }
}