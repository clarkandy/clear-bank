
using ClearBank.DeveloperTest.Domain.Payments;
using System;

namespace ClearBank.DeveloperTest.App
{
    class Program
    {
        private static readonly DependencyManager _dependencyManager = new DependencyManager();

        static void Main(string[] args)
        {
            IPaymentService paymentService = _dependencyManager.Resolve<IPaymentService>();

            Console.WriteLine("Dependencies resolve");
            Console.ReadLine();
        }
    }
}
