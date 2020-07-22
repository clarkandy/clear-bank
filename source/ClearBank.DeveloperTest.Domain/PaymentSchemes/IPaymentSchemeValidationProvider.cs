namespace ClearBank.DeveloperTest.Domain.PaymentSchemes
{
    public interface IPaymentSchemeValidationProvider
    {
        IPaymentSchemeValidator ProvideSchemeValidator(PaymentScheme paymentScheme);
    }
}