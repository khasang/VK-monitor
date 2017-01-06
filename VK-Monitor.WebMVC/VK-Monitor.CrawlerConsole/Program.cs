using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.CrawlerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new CrowlerModule());

            IDataManager dataManager = kernel.Get<IDataManager>();
            IVkService vkService = kernel.Get<IVkService>();

            Work work = new Work(dataManager, vkService);

            work.AddNewSubscriber();
        }
    }
}