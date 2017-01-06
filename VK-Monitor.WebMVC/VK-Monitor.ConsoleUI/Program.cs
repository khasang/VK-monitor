using Ninject;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKernel kernel = new StandardKernel(new CrowlerModule());

            //IVkService vkService = kernel.Get<IVkService>();
            //IDataManager dataManager = kernel.Get<IDataManager>();

            //var targetUsers = dataManager.TargetUsers.GetAll();
            //foreach (var user in targetUsers)
            //{
            //    var subscriber = vkService.GetSubscribers(user.VkId);
            //}

            var vkService = new VkService();
            ulong vkId = 123456;

            vkService.Authorize(1231241241, "12312312", "sasdfwer");

            var vkHandle = new VkHandle(vkService);

            var report = vkHandle.GetReportData(new Report4(), vkId);
            var groupList = (report.Answer["groups"] as List<Group>);
        }
    }
}
