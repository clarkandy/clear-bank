using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using Moq;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.Payments.PaymentServiceTests.MakePayment
{
    public class CanMakePaymentWhenValid : PaymentServiceTestBase
    {
        private readonly MakePaymentRequest _paymentRequest;

        private readonly Account _account;

        public CanMakePaymentWhenValid()
        {
            _paymentRequest = new MakePaymentRequest()
            {
                Amount = 5,
                DebtorAccountNumber = "1"
            };
            _account = new Account()
            {
                AccountNumber = "1",
                Balance = 10
            };
            _mockAccountDataStore.Setup(d => d.GetAccount(_account.AccountNumber)).Returns(_account);
            _mockPaymentSchemeValidationHandler.Setup(v => v.IsPaymentValid(_paymentRequest, _account)).Returns(true);
            _mockAccountDataStore.Setup(d => d.UpdateAccount(_account));
        }

        [Fact(DisplayName = "Can make Payment When Valid")]
        public void Test()
        {
            MakePaymentResult result = _paymentService.MakePayment(_paymentRequest);

            Assert.True(result.Success);
            Assert.Equal(5, _account.Balance);
            _mockAccountDataStore.Verify(d => d.GetAccount(_account.AccountNumber), Times.Once);
            _mockPaymentSchemeValidationHandler.Verify(v => v.IsPaymentValid(_paymentRequest, _account), Times.Once);
            _mockAccountDataStore.Verify(d => d.UpdateAccount(_account), Times.Once);
        }
    }
}
