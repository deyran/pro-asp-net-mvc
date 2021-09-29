using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace SportsStore.WebUI.Infrastructure
{
    /*
     AA GETTING STARTED
        SETTING UP THE DI CONTAINER
            Listing 7-1. The Contents of the NinjectDependencyResolver.cs file
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
            // put bindings here
        }
    }
}