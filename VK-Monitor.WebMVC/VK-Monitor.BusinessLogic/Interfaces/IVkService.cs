using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface IVkService
    {
        void Authorize(ulong applicationId, string adminId, string adminPassword);

        ReadOnlyCollection<User> GetUsers(IEnumerable<long> userIds, ProfileFields fields = null, NameCase nameCase = null);

        ReadOnlyCollection<long> GetLikesList(LikesGetListParams @params);

        ReadOnlyCollection<long> GetFriendsRecent(long? count = null);

        ReadOnlyCollection<User> GetFollowers(long? userId = null, int? count = null, int? offset = null, ProfileFields fields = null, NameCase nameCase = null);

        ReadOnlyCollection<User> GetSubscribers(long userId);
    }
}
