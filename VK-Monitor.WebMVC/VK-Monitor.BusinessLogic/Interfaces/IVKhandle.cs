using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VkNet;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface IVKhandle
    {
        VkApi GetVK { get; }
        object GetReportData(Report report, ulong targetUserId);
        void AddTarget(ulong userId);
        void DeleteTarget(ulong userId);
    }
}
