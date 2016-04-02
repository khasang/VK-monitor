using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Subscriber GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Subscriber item)
        {
            throw new NotImplementedException();
        }

        public void Update(Subscriber item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Subscriber item)
        {
            throw new NotImplementedException();
        }
    }
}
