using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EssencialTools.Models;
using Ninject;

namespace EssencialTools.Infrastructure
{
    /*
    BB USING NINJECT -> 123
        BBDD SETTING UP MVC DEPENDENCY INJECTION -> 127
            >> CREATING THE DEPENDENCY RESOLVER -> 127
                >>>> Listing 6-11. The content of the NinjectDependencyResolver.cs file -> 127
    
        BBEE CREATING CHAINS OF DEPENDENCY -> 130
            >> Listing 6-16. Binding another interface to its implementation in the NinjectDependencyResolver.cs file -> 131

        BBFF SPECIFYING PROPERTY AND CONSTRUCTOR PARAMETER VALUES -> 131
            >> Listing 6-18. Using the Ninject WithPropertyValue method in the NinjectDependencyResolver.cs file -> 132
            >> Listing 6-20. Specifying a constructor parameter in the NinjectDependencyresolver.cs -> 132

        BBGG USING CONDITIONAL BINDING -> 133
            >> Listing 6-22. Using conditional binding in the NinjectDependencyResolver.cs -> 134
    */

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBinding();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBinding()
        {
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            kernel.Bind<IDiscountHelper>()
                .To<DefaultDiscountHelper>()
                .WithConstructorArgument("discountParam", 50M);

            kernel.Bind<IDiscountHelper>()
                .To<FlexibleDiscountHelper>()
                .WhenInjectedInto<LinqValueCalculator>();
        }
    }
}