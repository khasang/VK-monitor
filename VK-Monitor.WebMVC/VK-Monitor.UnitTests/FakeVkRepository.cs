using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VK_Monitor.BusinessLogic.Interfaces;
using VkNet.Model.RequestParams;

namespace VK_Monitor.UnitTests
{
    public class FakeVkRepository : IVkRepository
    {
        ulong applicationId;
        string adminId;
        string adminPassword;

        public void Authorize(ulong applicationId, string adminId, string adminPassword)
        {
            this.applicationId = applicationId;
            this.adminId = adminId;
            this.adminPassword = adminPassword;
        }
        
        public Dictionary<string, IList<string>> Users(ulong userId)
        {
            throw new NotImplementedException();
        }
        
        public ReadOnlyCollection<long> LikesGetList(LikesGetListParams @params)
        {
            throw new NotImplementedException();
        }
    }
}
