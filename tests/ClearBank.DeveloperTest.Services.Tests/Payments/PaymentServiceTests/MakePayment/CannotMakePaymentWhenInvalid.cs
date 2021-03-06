﻿using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using Moq;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.Payments.PaymentServiceTests.MakePayment
{
    public class CannotMakePaymentWhenInvalid : PaymentServiceTestBase
    {
        private readonly MakePaymentRequest _paymentRequest;

        private readonly Account _account;

        public CannotMakePaymentWhenInvalid()
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
            _mockPaymentSchemeValidationHandler.Setup(v => v.IsPaymentValid(_paymentRequest, _account)).Returns(false);
        }

        [Fact(DisplayName = "Cannot Make Payment When Invalid")]
        public void Test()
        {
            MakePaymentResult result = _paymentService.MakePayment(_paymentRequest);

            Assert.False(result.Success);
            Assert.Equal(10, _account.Balance);
            _mockAccountDataStore.Verify(d => d.GetAccount(_account.AccountNumber), Times.Once);
            _mockPaymentSchemeValidationHandler.Verify(v => v.IsPaymentValid(_paymentRequest, _account), Times.Once);
            _mockAccountDataStore.Verify(d => d.UpdateAccount(It.IsAny<Account>()), Times.Never);
        }
    }
}
