using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace SportsStore.WebUI.Infrastructure
{
    /*
    CHAPTER 07 - SPORTSSTORE - A REAL APPLICATION
        GETTING STARTED
            SETTING UP THE DI CONTAINER - 159
                Listing 7-1. The contents of the NinjectDependencyResolver.cs file     
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
            throw new NotImplementedException();
        }

    }
}

