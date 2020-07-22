using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using System;

namespace ClearBank.DeveloperTest.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly IAccountDataStore _accountDataStore;

        private readonly IPaymentSchemeValidationHandler _paymentSchemeValidationHandler;

        public PaymentService(IAccountDataStore accountDataStore, IPaymentSchemeValidationHandler paymentSchemeValidationHandler)
        {
            _accountDataStore = accountDataStore;
            _paymentSchemeValidationHandler = paymentSchemeValidationHandler;
        }

        public MakePaymentResult MakePayment(MakePaymentRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            MakePaymentResult result = new MakePaymentResult();
            Account account = _accountDataStore.GetAccount(request.DebtorAccountNumber);

            if (_paymentSchemeValidationHandler.IsPaymentValid(request, account))
            {
                account.Balance -= request.Amount;
                _accountDataStore.UpdateAccount(account);
                result.Success = true;
            }
            else
                result.Success = false;

            return result;
        }
    }
}
