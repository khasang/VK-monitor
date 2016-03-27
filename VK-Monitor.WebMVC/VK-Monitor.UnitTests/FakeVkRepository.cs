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
        
        public ReadOnlyCollection<long> GetLikesList(LikesGetListParams @params)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<VkNet.Model.User> GetUsers(IEnumerable<long> userIds, VkNet.Enums.Filters.ProfileFields fields = null, VkNet.Enums.SafetyEnums.NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<long> GetFriendsRecent(long? count = null)
        {
            throw new NotImplementedException();
        }
    }
}
