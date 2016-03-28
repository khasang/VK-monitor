using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using Serilog;
using Serilog.Configuration;
using System.Collections.ObjectModel;
using VkNet.Model.RequestParams;
using VK_Monitor.BusinessLogic.Interfaces;
using VkNet.Model;

namespace VK_Monitor.BusinessLogic
{
    public class VkRepository : IVkRepository
    {
        VkApi vk = new VkApi();
        ILogger loggerService;

        public VkRepository(ILogger logerService = null)
        {
            this.loggerService = logerService;
        }

        public void Authorize(ulong applicationId, string adminId, string adminPassword)
        {
            ApiAuthParams authorize = new ApiAuthParams()
            {
                ApplicationId = applicationId,
                Login = adminId,
                Password = adminPassword,
                Settings = Settings.All
            };

            try
            {
                vk.Authorize(authorize);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }                        
        }

        public ReadOnlyCollection<long> GetLikesList(LikesGetListParams @params)
        {
            throw new NotImplementedException();
        }
        
        public ReadOnlyCollection<long> GetFriendsRecent(long? count = null)
        {
            ReadOnlyCollection<long> users = null;
            try
            {
                users = vk.Friends.GetRecent(count);
            }
            catch
            {
                if(loggerService != null)
                {
                    loggerService.Error("Ошибка получения подписчиков: users {@0}, авторизация {@1} пользователем {@2}", users, vk.IsAuthorized, vk.UserId);
                }

                Debug.WriteLine("Ошибка получения подписчиков");
            }

            return users;
        }

        public ReadOnlyCollection<User> GetUsers(IEnumerable<long> userIds, ProfileFields fields = null, VkNet.Enums.SafetyEnums.NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<User> GetFollowers(long? userId = null, int? count = null, int? offset = null, ProfileFields fields = null, VkNet.Enums.SafetyEnums.NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }
    }
}
