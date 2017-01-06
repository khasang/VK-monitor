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
using VkNet.Enums.SafetyEnums;

namespace VK_Monitor.BusinessLogic
{
    public class VkService : IVkService
    {
        VkApi vk = new VkApi();

        public VkService()
        {
            
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
        
        // Подписчики текущего пользователя
        public ReadOnlyCollection<long> GetFriendsRecent(long? count = null)
        {
            ReadOnlyCollection<long> users = null;
            try
            {
                users = vk.Friends.GetRecent(count);
            }
            catch
            {
                Logger.Error("Ошибка получения подписчиков: users {@0}, авторизация {@1} пользователем {@2}", users, vk.IsAuthorized, vk.UserId);                
                Debug.WriteLine("Ошибка получения подписчиков");
            }

            return users;
        }

        public ReadOnlyCollection<User> GetUsers(IEnumerable<long> userIds, ProfileFields fields = null, NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }

        // Получить подписчиков пользователя vkId
        public ReadOnlyCollection<User> GetFollowers(long? vkId = null, int? count = null, int? offset = null, ProfileFields fields = null, NameCase nameCase = null)
        {
            return vk.Users.GetFollowers(vkId, count, offset, fields, nameCase);
        }

        public ReadOnlyCollection<User> FriendsSearch(long userId)
        {
            var param = new FriendsSearchParams()
            { 
                Count = 100,
                UserId = userId
            };

            return vk.Friends.Search(param);
        }

        public ReadOnlyCollection<Group> GetGroups(long userId)
        {
            ReadOnlyCollection<Group> groups = null;
            try
            {
                groups = vk.Groups.Get(userId);
            }
            catch
            {
                Logger.Error("Ошибка получения списка групп: groups {@0}, пользователя {@1}", groups, userId);

                Debug.WriteLine("Ошибка получения списка групп");
            }
            return groups;
        }

        public WallGetObject GetWallRecords(long ownerId)
        {
            WallGetObject wallRecords = null;

            try
            {
                wallRecords = vk.Wall.Get(new WallGetParams { OwnerId = -ownerId });
            }
            catch
            {

                Logger.Error("Ошибка получения списка записей со стены: wallRecords {@0}, сообщества/пользователя {@1}", wallRecords, ownerId);

                Debug.WriteLine("Ошибка получения списка записей со стены");
            }
            return wallRecords;
        }

        public ReadOnlyCollection<Comment> GetPostComments(long ownerId, long postId)
        {
            int totalCount;

            ReadOnlyCollection<Comment> comments = null;

            try
            {
                comments = vk.Wall.GetComments(out totalCount, new WallGetCommentsParams { OwnerId = -ownerId, PostId = postId });
            }
            catch
            {
                Logger.Error("Ошибка получения списка комментариев : comments {@0}, к записи {@1}, сообщества {@2}", comments, postId, ownerId);

                Debug.WriteLine("Ошибка получения списка комментариев к записи");
            }
            return comments;
        }

        public bool IsLiked(LikeObjectType type, long itemId, long userId)
        {
            bool copied;

            if (vk.Likes.IsLiked(out copied, type = type, itemId = itemId, userId = userId))
                return true;
            else
                return false;
        }

        public bool IsSameAuthor(long commentId, long userId)
        {
            if (commentId == (long)userId)
                return true;
            else
                return false;
        }
    }
}
