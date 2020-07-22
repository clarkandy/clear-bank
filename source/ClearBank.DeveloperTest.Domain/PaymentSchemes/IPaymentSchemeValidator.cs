using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;

namespace ClearBank.DeveloperTest.Domain.PaymentSchemes
{
    public interface IPaymentSchemeValidator
    {
        bool IsPaymentValid(Account account, MakePaymentRequest paymentRequest);
    }
}
