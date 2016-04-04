using Ninject;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            // Здесь мапим зависимости
            // kernel.Bind<IOurInterface>().To<OurClass>();
            kernel.Bind<IDataManager>().To<DataManager>();
            kernel.Bind<ISubscriberRepository>().To<EFSubscriberRepository>();
            kernel.Bind<ITargetUserRepository>().To<EFTargetUserRepository>();
            kernel.Bind<IApplicationDbContext>().To<ApplicationDbContext>();
            //kernel.Bind<ApplicationDbContext>().ToSelf();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}