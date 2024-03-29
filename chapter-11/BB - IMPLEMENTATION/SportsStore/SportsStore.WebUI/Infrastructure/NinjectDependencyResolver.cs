﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

//Listing 7-5.
using System.Linq;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

//Listing 7-15
using SportsStore.Domain.Concrete;

//Listing 9-16
using System.Configuration;

namespace SportsStore.WebUI.Infrastructure
{
    /*
    AA GETTING STARTED
        SETTING UP THE DI CONTAINER
            Listing 7-1. The Contents of the NinjectDependencyResolver.cs file

    BB STARTING THE DOMAIN MODEL
        MAKING A MOCK REPOSITORY
            Listing 7-5. Adding the Mock IProductRepository implementation in the NinjectDependencyResolver.cs file

    DD PREPARING A DATABASE
	    CREATING THE PRODUCT REPOSITORY
		    Listing 7-15. Adding the real repository binding in the NinjectDependencyResolver.cs file

    SUBMITTING ORDERS
	    REGISTERING THE IMPLEMENTATION 247
		    Listing 9-16. Adding Ninject Bindings for IOrderProcessor to the NinjectDependencyResolver.cs File
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
            kernel.Bind<IProductRepository>().To<EFProductRepository>();

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager
                    .AppSettings["Email.WriteAsFile"] ?? "false")
            };

            kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>()
                .WithConstructorArgument("settings", emailSettings);
        }
    }
}