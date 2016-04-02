using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Models;
using VkNet;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface IReport
    {
        ReportModel GetData(IVkRepository vkRepository, ulong userId);
    }
}
