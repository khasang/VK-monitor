using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain.Implementaions
{
    public class EFFriendRepository : IFriendRepository
    {
        ApplicationDbContext dbContext;

        public EFFriendRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Friend> GetByOwnerId(long vkId)
        {
            return dbContext.Friends.Where(f => f.OwnerId == vkId);
        }

        public IEnumerable<Friend> GetAll()
        {
            return dbContext.Friends;
        }

        public Friend GetById(int id)
        {
            return dbContext.Friends.Find(id);
        }

        public void Add(Friend friend)
        {
            dbContext.Friends.Add(friend);
        }

        public void Update(Friend friend)
        {
            dbContext.Entry(friend).State = EntityState.Modified; ;
        }

        public void Delete(Friend friend)
        {
            Delete(friend.Id);
        }

        public void Delete(int id)
        {
            Friend friend = GetById(id);
            if (friend != null)
                dbContext.Friends.Remove(friend);
        }
    }
}
