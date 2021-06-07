using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssencialTools.Infrastructure
{
    /*
    BB USING NINJECT -> 123
    BBFF SPECIFYING PROPERTY AND CONSTRUCTOR PARAMETER VALUES -> 131
    >> Listing 6-18. Using the Ninject WithPropertyValue method in the NinjectDependencyResolver.cs file -> 132    
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

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>().WithPropertyValue("DiscountSize", 50M);
        }
    }
}