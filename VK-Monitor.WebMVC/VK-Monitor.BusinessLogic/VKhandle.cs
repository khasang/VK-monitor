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
    public class VKhandle : IVKhandle
    {
        string adminId = string.Empty;
        string adminPassword = string.Empty;
        ulong applicationId;

        VkApi vk;

        List<ulong> users = new List<ulong>();

        public VKhandle(ulong applicationId, string adminId, string adminPassword)
        {
            this.applicationId = applicationId;
            this.adminId = adminId;
            this.adminPassword = adminPassword;

            ApiAuthParams authorize = new ApiAuthParams()
            {
                ApplicationId = applicationId,
                Login = adminId,
                Password = adminPassword,
                Settings = Settings.All
            };

            vk = new VkApi();

            try
            {
                vk.Authorize(authorize);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }           
        }

        public VkApi GetVK
        {
            get { return vk; }
        }

        public object GetReportData(Report report, ulong targetUserId)
        {
            return report.GetData(vk, targetUserId);
        }

        public void AddUserId(ulong userId)
        {
            users.Add(userId);
        }

        public void DeleteUserId(ulong userId)
        {
            users.Remove(userId);
        }

    }
}
