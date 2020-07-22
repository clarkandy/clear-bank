using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;

namespace ClearBank.DeveloperTest.Validators.PaymentSchemes
{
    public class FasterPaymentsSchemeValidator : PaymentSchemeValidator, IFasterPaymentsSchemeValidator
    {
        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.FasterPayments;

        public override bool IsPaymentValid(Account account, MakePaymentRequest paymentRequest)
            => base.IsPaymentValid(account, paymentRequest) && account.Balance >= paymentRequest.Amount;
    }
}
