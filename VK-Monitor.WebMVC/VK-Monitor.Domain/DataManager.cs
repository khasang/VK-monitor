using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Implementaions;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain
{
    public class DataManager : IDataManager, IDisposable
    {
        ApplicationDbContext dbContext;

        ISubscriberRepository subscriber;
        ITargetUserRepository targetUser;

        public DataManager()
        {
            dbContext = new ApplicationDbContext();
        }

        public DataManager(string connectionString)
        {
            dbContext = new ApplicationDbContext(connectionString);
        }

        public ISubscriberRepository Subscribers
        {
            get
            {
                if (subscriber == null)
                    subscriber = new EFSubscriberRepository(dbContext);
                return subscriber;
            }
        }

        public ITargetUserRepository TargetUsers
        {
            get
            {
                if (targetUser == null)
                    targetUser = new EFTargetUserRepository(dbContext);
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
