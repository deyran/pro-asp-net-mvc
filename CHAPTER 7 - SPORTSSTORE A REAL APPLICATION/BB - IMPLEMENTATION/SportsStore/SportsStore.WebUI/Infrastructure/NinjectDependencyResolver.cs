using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

//Listing 7-5.
using System.Linq;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure
{
    /*
    AA GETTING STARTED
        SETTING UP THE DI CONTAINER
            Listing 7-1. The Contents of the NinjectDependencyResolver.cs file

    BB STARTING THE DOMAIN MODEL
        MAKING A MOCK REPOSITORY
            Listing 7-5. Adding the Mock IProductRepository implementation in the NinjectDependencyResolver.cs file
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
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            mock.Setup(m => m.Products).Returns(
                new List<Product>
                {
                    new Product {Name = "FootBall", Price = 25},
                    new Product {Name = "Surf", Price = 179},
                    new Product {Name = "Running shoes", Price = 95}
                }
            );

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}