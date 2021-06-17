using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Ninject.Web.Common;

namespace EssentialTools.Infrastructure
{
    /*
    BB USING NINJECT -> 123
    BBHH SETTING THE OBJECT SCOPE -> 134
    >> Listing 6-25. Using the request scope in the NinjectDependencyResolver.cs file -> 135
    */
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetService(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IValueCalculator>()
                  .To<LinqValueCalculator>()
                  .InRequestScope();

            kernel.Bind<IDiscountHelper>()
                  .To<DefaultDiscountHelper>()
                  .WithConstructorArgument("discountParam", 50M);

            kernel.Bind<IDiscountHelper>()
                  .To<FlexibleDiscountHelper>()
                  .WhenInjectedInto<LinqValueCalculator>();
        }
    }
}