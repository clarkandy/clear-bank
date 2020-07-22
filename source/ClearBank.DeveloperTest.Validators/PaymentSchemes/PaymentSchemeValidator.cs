using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;

namespace ClearBank.DeveloperTest.Validators.PaymentSchemes
{
    public abstract class PaymentSchemeValidator : IPaymentSchemeValidator
    {
        protected abstract AllowedPaymentSchemes AllowedPaymentSchemes { get; }

        public virtual bool IsPaymentValid(Account account, MakePaymentRequest paymentRequest)
            => (account?.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes)).GetValueOrDefault() && paymentRequest != null;
    }
}
