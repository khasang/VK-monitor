using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Model.RequestParams;

namespace VK_Monitor.BusinessLogic.Interfaces
{
    public interface IVkRepository
    {
        void Authorize(ulong applicationId, string adminId, string adminPassword);

        Dictionary<string, IList<string>> Users(ulong userId);

        ReadOnlyCollection<long> LikesGetList(LikesGetListParams @params);

    }
}
