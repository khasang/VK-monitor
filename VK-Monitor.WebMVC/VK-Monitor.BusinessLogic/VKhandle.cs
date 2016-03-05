using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.BusinessLogic.Interfaces;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;

namespace VK_Monitor.BusinessLogic
{
    public class VKhandle : IVKhandle
    {
        string adminId = string.Empty;
        string adminPassword = string.Empty;

        VkApi vk;

        public VKhandle(string adminId, string adminPassword)
        {
            this.adminId = adminId;
            this.adminPassword = adminPassword;

            ApiAuthParams authorize = new ApiAuthParams()
            {
                ApplicationId = 1111111,
                Login = adminId,
                Password = adminPassword,
                //Settings = Settigs.All
            };

            vk = new VkApi();
            vk.Authorize(authorize);
        }

        public VkApi GetVKHandler()
        {
            return vk;
        }
    }
}
