using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Models;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;

namespace VK_Monitor.BusinessLogic
{
    public class VkHandle : IVKhandle
    {
        IVkService vkService;
        List<ulong> targets;

        public VkHandle(IVkService vkService)
        {
            this.vkService = vkService;

            targets = new List<ulong>();
        }

        public ReportModel GetReportData(IReport report, ulong targetUserId)
        {
            return report.GetData(vkService, targetUserId);
        }

        public void AddTarget(ulong userId)
        {
            targets.Add(userId);
        }

        public void DeleteTarget(ulong userId)
        {
            targets.Remove(userId);
        }
        
        public IList<ulong> GetTargets()
        {
            return targets;
        }
    }
}
