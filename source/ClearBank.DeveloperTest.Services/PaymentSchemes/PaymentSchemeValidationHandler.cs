using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using System;

namespace ClearBank.DeveloperTest.Services.PaymentSchemes
{
    public class PaymentSchemeValidationHandler : IPaymentSchemeValidationHandler
    {
        private readonly IPaymentSchemeValidationProvider _paymentSchemeValidationProvider;

        public PaymentSchemeValidationHandler(IPaymentSchemeValidationProvider paymentSchemeValidationProvider)
            => _paymentSchemeValidationProvider = paymentSchemeValidationProvider;

        public bool IsPaymentValid(MakePaymentRequest paymentRequest, Account account)
        {
            if (paymentRequest == null)
                throw new ArgumentNullException(nameof(paymentRequest));

            if (account == null)
                throw new ArgumentNullException(nameof(account));

            return _paymentSchemeValidationProvider.ProvideSchemeValidator(paymentRequest.PaymentScheme)
                .IsPaymentValid(account, paymentRequest);
        }
    }
}
