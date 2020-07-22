using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;

namespace ClearBank.DeveloperTest.Validators.PaymentSchemes
{
    public class BacsSchemeValidator : PaymentSchemeValidator, IBacsSchemeValidator
    {
        protected override AllowedPaymentSchemes AllowedPaymentSchemes => AllowedPaymentSchemes.Bacs;
    }
}
