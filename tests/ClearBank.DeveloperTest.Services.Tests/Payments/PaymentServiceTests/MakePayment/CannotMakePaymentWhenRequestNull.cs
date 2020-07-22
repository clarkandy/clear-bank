using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClearBank.DeveloperTest.Services.Tests.Payments.PaymentServiceTests.MakePayment
{
    public class CannotMakePaymentWhenRequestNull : PaymentServiceTestBase
    {
        [Fact(DisplayName = "Cannot Make Payment When Request Null")]
        public void Test()
            => Assert.Throws<ArgumentNullException>(() => _paymentService.MakePayment(null));
    }
}
