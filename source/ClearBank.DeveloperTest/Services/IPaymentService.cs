using ClearBank.DeveloperTest.Domain.Payments;

namespace ClearBank.DeveloperTest.Services
{
    public interface IPaymentService
    {
        MakePaymentResult MakePayment(MakePaymentRequest request);
    }
}
