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
    public class Work
    {
        IDataManager dataManager;
        IVkService vkService;

        public Work(IDataManager dataManager, IVkService vkService)
        {
            this.dataManager = dataManager;
            this.vkService = vkService;
        }

        public void AddNewSubscriber()
        {
            var targetUsers = dataManager.TargetUsers.GetAll();
            foreach (var target in targetUsers)
            {                
                var subscribersNew = GetNewSubscribers(target);
                foreach (var subscrber in subscribersNew)
                {
                    dataManager.Subscribers.Add(subscrber);
                }

                var friendsNew = GetNewFriends(target);
                foreach (var subscrber in subscribersNew)
                {
                    dataManager.Subscribers.Add(subscrber);
                }
            }
            dataManager.Save();
        }

        private IList<Subscriber> GetNewSubscribers(TargetUser target)
        {
            var subscribersBefor = target.Subscribers.ToList();
            return vkService.GetFollowers(target.VkId)
                            .Where(n => (subscribersBefor.FirstOrDefault(b => b.VkId == n.Id) == null))
                            .Select(n => new Subscriber { VkId = n.Id, Date = DateTime.Now, Owner = target }).ToList();
        }

        private IList<Friend> GetNewFriends(TargetUser target)
        {
            var friendsBefor = target.Friends.ToList();
            return vkService.GetFollowers(target.VkId)
                            .Where(n => (friendsBefor.FirstOrDefault(b => b.VkId == n.Id) == null))
                            .Select(n => new Friend { VkId = n.Id, Date = DateTime.Now, Owner = target }).ToList();
        }
    }
}
