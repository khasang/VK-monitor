﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VK_Monitor.BusinessLogic.Interfaces;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace VK_Monitor.UnitTests.FakeClasses
{
    public class FakeVkService : IVkService
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

        public ReadOnlyCollection<User> GetUsers(IEnumerable<long> userIds, VkNet.Enums.Filters.ProfileFields fields = null, VkNet.Enums.SafetyEnums.NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<long> GetFriendsRecent(long? count = null)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<User> GetFollowers(long? userId = null, int? count = null, int? offset = null, VkNet.Enums.Filters.ProfileFields fields = null, VkNet.Enums.SafetyEnums.NameCase nameCase = null)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<User> GetSubscribers(long userId)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<User> FriendsSearch(long userId)
        {
            throw new NotImplementedException();
        }


        public ReadOnlyCollection<Group> GetGroups(long userId)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Comment> GetPostComments(long ownerId, long postId)
        {
            throw new NotImplementedException();
        }

        public WallGetObject GetWallRecords(long ownerId)
        {
            throw new NotImplementedException();
        }

        public bool IsLiked(VkNet.Enums.SafetyEnums.LikeObjectType type, long itemId, long userId)
        {
            throw new NotImplementedException();
        }

        public bool IsSameAuthor(long commentId, long userId)
        {
            throw new NotImplementedException();
        }
    }
}
