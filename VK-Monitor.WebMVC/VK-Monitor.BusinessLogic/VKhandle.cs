using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VK_Monitor.Domain.Entities;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;

namespace VK_Monitor.BusinessLogic
{
    public class VkHandle : IVKhandle
    {
        IVkRepository vkRepository;
        ILogger loggerService;

        List<ulong> targets;

        public VkHandle(IVkRepository vkRepository, ILogger loggerService)
        {
            this.vkRepository = vkRepository;
            this.loggerService = loggerService;

            targets = new List<ulong>();
        }

        public ReportModel GetReportData(IReport report, ulong targetUserId)
        {
            return report.GetData(vkRepository, targetUserId);
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
