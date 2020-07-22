using Autofac;
using Autofac.Core;
using ClearBank.DeveloperTest.App.Settings;
using ClearBank.DeveloperTest.DataStores;
using ClearBank.DeveloperTest.Domain;
using ClearBank.DeveloperTest.Domain.Accounts;
using ClearBank.DeveloperTest.Domain.Payments;
using ClearBank.DeveloperTest.Domain.PaymentSchemes;
using ClearBank.DeveloperTest.Services.Payments;
using ClearBank.DeveloperTest.Services.PaymentSchemes;
using ClearBank.DeveloperTest.Validators.PaymentSchemes;
using System;

namespace ClearBank.DeveloperTest.App
{
    public class DependencyManager : IDependencyLocator
    {
        private static readonly IContainer _container;

        static DependencyManager()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<DependencyManager>().As<IDependencyLocator>().SingleInstance();
            builder.RegisterType<AccountDataStoreSettings>().As<IAccountDataStoreSettings>().SingleInstance();
            builder.RegisterType<PaymentService>().As<IPaymentService>();
            builder.RegisterType<PaymentSchemeValidationHandler>().As<IPaymentSchemeValidationHandler>();
            builder.RegisterType<PaymentSchemeValidationProvider>().As<IPaymentSchemeValidationProvider>();
            builder.RegisterType<BacsSchemeValidator>().As<IBacsSchemeValidator>();
            builder.RegisterType<ChapsSchemeValidator>().As<IChapsSchemeValidator>();
            builder.RegisterType<FasterPaymentsSchemeValidator>().As<IFasterPaymentsSchemeValidator>();
            builder.RegisterType<AccountDataStore>().AsSelf();
            builder.RegisterType<BackupAccountDataStore>().AsSelf();
            builder.Register<IAccountDataStore>(context =>
            {
                IAccountDataStoreSettings settings = context.Resolve<IAccountDataStoreSettings>();      //TODO: Move this logic out to enable unit testing

                switch (settings.DataStoreType)
                {
                    case Domain.Data.DataStoreTypes.Main:
                        return context.Resolve<AccountDataStore>();
                    case Domain.Data.DataStoreTypes.Backup:
                        return context.Resolve<BackupAccountDataStore>();
                    default:
                        throw new NotSupportedException($"{settings.DataStoreType} is not a supported Account Data Store");
                }
            });
            _container = builder.Build();
        }

        public T Resolve<T>()
            => _container.Resolve<T>();
    }
}
