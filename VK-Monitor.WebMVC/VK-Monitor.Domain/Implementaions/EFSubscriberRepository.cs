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
    public class EFSubscriberRepository : ISubscriberRepository
    {
        ApplicationDbContext dbContext;

        public EFSubscriberRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Subscriber> GetAll()
        {
            return dbContext.Subscribers;
        }

        public Subscriber GetById(int id)
        {
            return dbContext.Subscribers.Find(id);
        }

        public void Add(Subscriber subscriber)
        {
            dbContext.Subscribers.Add(subscriber);
        }

        public void Update(Subscriber subscriber)
        {
            dbContext.Entry(subscriber).State = EntityState.Modified;
        }

        public void Delete(Subscriber subscriber)
        {
            Delete(subscriber.Id);
        }

        public void Delete(int id)
        {
            Subscriber subscriber = GetById(id);
            if (subscriber != null)
                dbContext.Subscribers.Remove(subscriber);
        }
    }
}
