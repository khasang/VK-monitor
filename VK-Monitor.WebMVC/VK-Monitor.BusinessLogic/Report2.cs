using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VkNet;

namespace VK_Monitor.BusinessLogic
{
    public class Report2 : IReport
    {
        public ReportModel GetData(IVkRepository vkRepository, ulong userId)
        {
            throw new NotImplementedException();
        }
    }
}
