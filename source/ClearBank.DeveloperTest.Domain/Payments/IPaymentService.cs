namespace ClearBank.DeveloperTest.Domain.Payments
{
    public interface IPaymentService
    {
        MakePaymentResult MakePayment(MakePaymentRequest request);
    }
}
