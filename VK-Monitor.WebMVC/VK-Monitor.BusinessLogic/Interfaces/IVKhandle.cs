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
    public interface IVKhandle
    {
        ReportModel GetReportData(IReport report, ulong targetUserId);
        void AddTarget(ulong userId);
        void DeleteTarget(ulong userId);
        IList<ulong> GetTargets();
    }
}
