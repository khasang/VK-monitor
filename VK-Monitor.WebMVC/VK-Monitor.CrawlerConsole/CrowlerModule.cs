using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.CrawlerConsole
{
    class CrowlerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IVkService>().To<VkService>();
            Bind<IDataManager>().To<DataManager>();
            Bind<ITargetUserRepository>().To<EFTargetUserRepository>();
            Bind<ISubscriberRepository>().To<EFSubscriberRepository>();
            Bind<IApplicationDbContext>().To<ApplicationDbContext>();
        }        
    }
}
