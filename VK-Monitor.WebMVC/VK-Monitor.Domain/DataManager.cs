using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain
{
    public class DataManager : IDataManager
    {
        ApplicationDbContext dbContext;

        ISubscriberRepository subscriber;
        ITargetUserRepository targetUser;

        public DataManager(ApplicationDbContext dbContext,
                           ITargetUserRepository targetUser,
                           ISubscriberRepository subscriber)
        {            
            this.targetUser = targetUser;
            this.subscriber = subscriber;

            this.dbContext = dbContext;
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
