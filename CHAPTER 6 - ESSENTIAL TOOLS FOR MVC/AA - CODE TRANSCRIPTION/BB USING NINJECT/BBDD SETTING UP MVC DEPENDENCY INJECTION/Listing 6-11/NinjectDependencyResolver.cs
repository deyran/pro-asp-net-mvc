using System;
using System.Collections.Generic;
using Systen.Web.Mvc;
using EssencialTools.Models;
using Ninject;

namespace EssencialTools.Infrastructure
{
    /*
    BB USING NINJECT -> 123
    BBDD SETTING UP MVC DEPENDENCY INJECTION -> 127
    >> CREATING THE DEPENDENCY RESOLVER -> 127
    >>>> Listing 6-11. The content of the NinjectDependencyResolver.cs file -> 127    
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
        }
    }
}