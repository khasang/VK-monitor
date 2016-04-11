using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;
using VK_Monitor.Domain.Models;

namespace VK_Monitor.BusinessLogic
{
    public class Report3 //: IReport
    {
        public ReportModel GetData(IDataManager dataManager, long vkId)
        {
            var report = new ReportModel();

            var subscribers = dataManager.Subscribers.GetAll().Where(s => s.OwnerId == vkId && s.Date.Date == DateTime.Today).ToList();
            report.Answer.Add("subscribers", subscribers);

            var friends = dataManager.Friends.GetAll().Where(f => f.OwnerId == vkId && f.Date.Date == DateTime.Today).ToList();
            report.Answer.Add("friends", friends);

            return report;
        }
    }
}
