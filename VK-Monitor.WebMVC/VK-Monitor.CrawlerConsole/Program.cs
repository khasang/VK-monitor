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

            IVkService vkService = kernel.Get<IVkService>();
            IDataManager dataManager = kernel.Get<IDataManager>();

            var users = dataManager.Users.ToList();
            var targetUsers = dataManager.TargetUsers.GetAll();

            foreach (var target in targetUsers)
            {
                var subscribersBefor = target.Subscribers.ToList();
                var subscribersNew = vkService.GetSubscribers(target.VkId)
                                              .Where(n => subscribersBefor.FirstOrDefault(b => b.VkId == n.Id) == null)
                                              .Select(n => new Subscriber { VkId = n.Id, Date = DateTime.Now, Owner = target });

                foreach (var subscrber in subscribersNew)
                {
                    dataManager.Subscribers.Add(subscrber);
                }                
            }

            dataManager.Save();
        }
    }
}