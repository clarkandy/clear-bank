using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;

namespace ClearBank.DeveloperTest.Domain.PaymentSchemes
{
    public interface IPaymentSchemeValidationHandler
    {
        bool IsPaymentValid(MakePaymentRequest paymentRequest, Account account);
    }
}
