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
    public class EFTargetUserRepository : ITargetUserRepository
    {
        ApplicationDbContext dbContext;

        public EFTargetUserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TargetUser> GetAll()
        {
            return dbContext.TargetUsers;
        }

        public TargetUser GetById(int id)
        {
            return dbContext.TargetUsers.Find(id);
        }

        public void Add(TargetUser targetUser)
        {
            dbContext.TargetUsers.Add(targetUser);
        }

        public void Update(TargetUser targetUser)
        {
            dbContext.Entry(targetUser).State = EntityState.Modified;
        }

        public void Delete(TargetUser targetUser)
        {
            Delete(targetUser.Id);
        }

        public void Delete(int id)
        {
            TargetUser targetUser = GetById(id);
            if (targetUser != null)
                dbContext.TargetUsers.Remove(targetUser);
        }
    }
}
