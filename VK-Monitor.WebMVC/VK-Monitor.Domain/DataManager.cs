using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain
{
    public class DataManager : IDataManager
    {
        IApplicationDbContext dbContext;

        IFriendRepository friend;
        ISubscriberRepository subscriber;
        ITargetUserRepository targetUser;

        public DataManager(IApplicationDbContext dbContext,
                           ITargetUserRepository targetUser,
                           ISubscriberRepository subscriber)
        {            
            this.targetUser = targetUser;
            this.subscriber = subscriber;

            if (dbContext == null)
                throw new NullReferenceException("ApplicationDbContext равен NULL");
            this.dbContext = dbContext;
        }

        public IFriendRepository Friends
        {
            get
            {
                if (friend == null)
                    throw new NullReferenceException("Subscribers равен NULL");

                return friend;
            }
        }

        public ISubscriberRepository Subscribers
        {
            get
            {
                if (subscriber == null)
                    throw new NullReferenceException("Subscribers равен NULL");

                return subscriber;
            }
        }

        public ITargetUserRepository TargetUsers
        {
            get
            {
                if (targetUser == null)
                    throw new NullReferenceException("TargetUsers равен NULL");

                return targetUser;
            }
        }

        public IDbSet<ApplicationUser> Users
        {
            get
            {
                return dbContext.GetUsers();
            }
        }

        public IDbSet<IdentityRole> Roles
        {
            get
            {
                return dbContext.GetRoles();
            }
        }
        
        public void Save()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
