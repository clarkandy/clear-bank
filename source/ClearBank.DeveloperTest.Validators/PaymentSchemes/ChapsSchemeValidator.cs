using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;

namespace ClearBank.DeveloperTest.Validators.PaymentSchemes
{
    public class ChapsSchemeValidator : PaymentSchemeValidator, IChapsSchemeValidator
    {
        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.Chaps;

        public override bool IsPaymentValid(Account account, MakePaymentRequest paymentRequest)
            => base.IsPaymentValid(account, paymentRequest) && account.Status == AccountStatus.Live;
    }
}
